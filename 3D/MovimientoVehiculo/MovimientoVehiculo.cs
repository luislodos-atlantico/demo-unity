using UnityEngine;

public class MovimientoVehiculo : MonoBehaviour
{
    public float fuerza;
    Rigidbody cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // AVANZAR
        cuerpo.AddRelativeForce(fuerza * Input.GetAxis("Vertical") * Vector3.forward);

        // GIRO
        cuerpo.AddTorque(fuerza * Input.GetAxis("Horizontal") * Vector3.up);
    }
}
