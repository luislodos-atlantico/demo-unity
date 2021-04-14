using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    public KeyCode tecla = KeyCode.Space;
    public float velocidad = 100;

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            var creado = Instantiate(bala);
            var cuerpo = creado.GetComponent<Rigidbody>();
            cuerpo.velocity = velocidad * Vector3.forward;
        }
    }
}
