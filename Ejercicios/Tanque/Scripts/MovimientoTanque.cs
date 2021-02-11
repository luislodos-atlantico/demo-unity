using UnityEngine;

public class MovimientoTanque : MonoBehaviour
{
    public float aceleracion = 10;
    public Rigidbody2D cuerpo;

    void FixedUpdate()
    {
        var fuerza = aceleracion * cuerpo.mass;
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddForce(fuerza * Vector2.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddForce(fuerza * Vector2.left);
        }
    }
}