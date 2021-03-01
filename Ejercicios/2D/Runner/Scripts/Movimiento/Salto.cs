using UnityEngine;

public class Salto : MonoBehaviour
{
    public float velocidad_salto = 5;
    public DetectorSuelo detector;
    public Animator animador;
    Rigidbody2D cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && detector.enSuelo)
        {
            cuerpo.AddForce(velocidad_salto * Vector2.up, ForceMode2D.Impulse);
            animador.SetTrigger("saltar");
        }
    }
}