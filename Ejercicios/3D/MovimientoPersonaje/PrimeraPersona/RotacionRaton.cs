using UnityEngine;

public class RotacionRaton : MonoBehaviour
{
    public float sensibilidad = 500;
    Vector3 rotacionRaton;

    void Update()
    {
        rotacionRaton.y += Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;
        rotacionRaton.z = 0;
        transform.rotation = Quaternion.Euler(rotacionRaton);
    }
}
