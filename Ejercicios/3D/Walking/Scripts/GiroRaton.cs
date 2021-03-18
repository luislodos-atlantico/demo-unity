using UnityEngine;

public class GiroRaton : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerza;

    void FixedUpdate()
    {
        var ejeRaton = Input.GetAxis("Mouse X");
        cuerpo.angularVelocity = ejeRaton * Vector3.up * fuerza;
    }
}
