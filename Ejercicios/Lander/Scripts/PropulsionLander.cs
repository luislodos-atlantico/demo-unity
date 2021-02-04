using UnityEngine;

public class PropulsionLander : MonoBehaviour
{
    public float fuerzaPropulsion = 10;
    public Combustible combustible;
    Rigidbody2D cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && combustible.combustible > 0)
        {
            cuerpo.AddRelativeForce(fuerzaPropulsion * Vector2.up);
        }
    }
}
