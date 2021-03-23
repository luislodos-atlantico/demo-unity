using UnityEngine;

public class MovimientoRigidbody3D : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerza;

    void FixedUpdate()
    {
        // AVANZAR
        cuerpo.AddRelativeForce(fuerza * Input.GetAxis("Vertical") * Vector3.forward);

        // GIRO
        cuerpo.AddTorque(fuerza * Input.GetAxis("Horizontal") * Vector3.up);
    }
}
