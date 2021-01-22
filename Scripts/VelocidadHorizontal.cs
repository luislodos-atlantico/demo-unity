using UnityEngine;

public class VelocidadHorizontal : MonoBehaviour
{
    public float velocidad = 2;
    Rigidbody2D cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var velocidadHorizontal = 0f;
        var velocidadVertical = cuerpo.velocity.y;
        if (Input.GetKey(KeyCode.D))
        {
            velocidadHorizontal = velocidad;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocidadHorizontal = -velocidad;
        }
        cuerpo.velocity = new Vector2(velocidadHorizontal, velocidadVertical);
    }
}
