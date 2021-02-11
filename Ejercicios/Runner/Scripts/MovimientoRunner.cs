using UnityEngine;

public class MovimientoRunner : MonoBehaviour
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
        velocidadHorizontal = velocidad;
        cuerpo.velocity = new Vector2(velocidadHorizontal, velocidadVertical);
    }
}
