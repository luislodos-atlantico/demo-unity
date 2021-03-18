using UnityEngine;

public class GiroTeclas : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerza;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddTorque(fuerza * Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddTorque(fuerza * Vector3.down);
        }
    }
}
