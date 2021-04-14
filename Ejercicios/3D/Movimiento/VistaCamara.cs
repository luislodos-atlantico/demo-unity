using UnityEngine;

public class VistaCamara : MonoBehaviour
{
    public float sensibilidad = 100;

    void Update()
    {
        var rotacion = transform.rotation.eulerAngles;
        rotacion.x -= Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotacion);
    }
}
