using UnityEngine;

public class Movimiento3D : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerzaAvance;
    public float fuerzaGiro;

    void Update()
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

        // LATERAL
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.D))
        {
            cuerpo.AddForce(fuerzaAvance * Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.A))
        {
            cuerpo.AddForce(fuerzaAvance * Vector3.left);
        }

        // ROTACION
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
