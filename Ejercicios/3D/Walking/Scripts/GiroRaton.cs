using UnityEngine;

public class GiroRaton : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerza;

    void FixedUpdate()
    {
        cuerpo.AddTorque(Input.GetAxis("Mouse X") * Vector3.up * fuerza);
    }
}
