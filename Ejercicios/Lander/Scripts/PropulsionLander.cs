using UnityEngine;

public class PropulsionLander : MonoBehaviour
{
    public float fuerzaPropulsion = 10;
    public Combustible combustible;
    public Rigidbody2D cuerpo;

    void FixedUpdate()
    {
        if (combustible.cantidad <= 0)
        {
            return;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            cuerpo.AddRelativeForce(fuerzaPropulsion * Vector2.up);
        }
    }
}
