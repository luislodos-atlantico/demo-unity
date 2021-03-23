using UnityEngine;

public class MovimientoRigidbody3D : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerza;

    void FixedUpdate()
    {
        // AVANZAR
        if (Input.GetKey(KeyCode.W))
        {
            cuerpo.AddRelativeForce(fuerza * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cuerpo.AddRelativeForce(fuerza * Vector3.back);
        }

        // GIRO TECLAS
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddTorque(fuerza * Vector3.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddTorque(fuerza * Vector3.down);
        }

        // GIRO RATÓN
        var ejeRaton = Input.GetAxis("Mouse X");
        cuerpo.angularVelocity = ejeRaton * Vector3.up * fuerza;
    }
}
