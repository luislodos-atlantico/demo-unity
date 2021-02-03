using UnityEngine;

public class PropulsionLander : MonoBehaviour
{
    public float fuerzaPropulsion = 10;
    Rigidbody2D cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cuerpo.AddRelativeForce(fuerzaPropulsion * Vector2.up);
        }
    }
}
