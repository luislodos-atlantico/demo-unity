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
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddForce(aceleracion * Vector2.right);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddForce(aceleracion * Vector2.left);
        }
    }
}