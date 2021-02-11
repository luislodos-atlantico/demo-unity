using UnityEngine;

public class MovimientoRunner : MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public Animator animador;
    public float velocidad = 5;

    void Start()
    {
        animador.SetBool("corriendo", true);
    }

    void FixedUpdate()
    {
        var nuevaVelocidad = cuerpo.velocity;
        nuevaVelocidad.x = velocidad;
        cuerpo.velocity = nuevaVelocidad;
    }
}
