using UnityEngine;

public class MovimientoCorrer : MonoBehaviour
{
    public Animator animador;
    public Rigidbody2D cuerpo;
    public float velocidad = 2;

    void FixedUpdate()
    {
        var velocidadHorizontal = 0f;
        var velocidadVertical = cuerpo.velocity.y;
        if (Input.GetKey(KeyCode.D))
        {
            velocidadHorizontal = velocidad;
            animador.SetBool("corriendo", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocidadHorizontal = -velocidad;
            animador.SetBool("corriendo", true);
        }
        else
        {
            animador.SetBool("corriendo", false);
        }
        cuerpo.velocity = new Vector2(velocidadHorizontal, velocidadVertical);
    }
}
