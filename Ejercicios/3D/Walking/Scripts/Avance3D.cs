using UnityEngine;

public class Avance3D : MonoBehaviour
{
    public Rigidbody cuerpo;
    public float fuerza;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cuerpo.AddRelativeForce(fuerza * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cuerpo.AddRelativeForce(fuerza * Vector3.back);
        }
    }
}
