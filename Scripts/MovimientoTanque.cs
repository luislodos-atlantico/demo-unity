using UnityEngine;

public class MovimientoTanque: MonoBehaviour
{
    public float velocidad = 1;
    public float velocidad_salto = 5;
    public DetectorSuelo detector;
    Rigidbody2D cuerpo;
   
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddForce(velocidad * Vector2.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddForce(velocidad * Vector2.left);
        }               
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && detector.enSuelo)
        {
            cuerpo.AddForce(velocidad_salto * Vector2.up, ForceMode2D.Impulse);
        }
    }
}