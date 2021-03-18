using UnityEngine;

public class Movimiento3D : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerzaAvance;
    public float fuerzaGiro;

    void FixedUpdate()
    {
        // AVANCE
        if (Input.GetKey(KeyCode.W))
        {
            cuerpo.AddRelativeForce(fuerzaAvance * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cuerpo.AddRelativeForce(fuerzaAvance * Vector3.back);
        }

        // GIRO
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddTorque(fuerzaGiro * Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddTorque(fuerzaGiro * Vector3.down);
        }
    }
}
