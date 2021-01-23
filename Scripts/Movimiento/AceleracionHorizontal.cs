using UnityEngine;

public class AceleracionHorizontal : MonoBehaviour
{
    public float aceleracion = 10;
    Rigidbody2D cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

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