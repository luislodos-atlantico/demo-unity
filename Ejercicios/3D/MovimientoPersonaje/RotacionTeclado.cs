using UnityEngine;

public class RotacionTeclado : MonoBehaviour
{
    public float velocidadRotacion = 100;

    void Update()
    {
        var rotacion_teclado = Vector3.zero;
        rotacion_teclado.y = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(rotacion_teclado);
    }
}
