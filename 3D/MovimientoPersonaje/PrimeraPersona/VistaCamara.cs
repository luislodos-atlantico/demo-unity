using UnityEngine;

public class VistaCamara : MonoBehaviour
{
    public float sensibilidad = 100;
    float contador;

    void Update()
    {
        if (Application.isEditor && contador < 1.0f)
        {
            contador += Time.deltaTime;
            return;
        }

        var rotacion = transform.rotation.eulerAngles;
        rotacion.x -= Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotacion);
    }
}
