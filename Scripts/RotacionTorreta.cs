using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTorreta : MonoBehaviour
{
    public float velocidad = 1;
    public float rotacionSuperiorMaxima = 60;
    public float rotacionSuperiorMinima = 10;

    void Update()
    {
        // Rotar
        var posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var objetivoX = posicionRaton.x;
        var objetivoY = posicionRaton.y;
        var objetivoZ = 0;
        var objetivo = new Vector3(objetivoX, objetivoY, objetivoZ);
        transform.right = objetivo - transform.position;

        // Limitar rotación
        var rotacion = transform.rotation;
        if (rotacion.eulerAngles.z > rotacionSuperiorMaxima)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotacionSuperiorMaxima));
        }
        else if (rotacion.eulerAngles.z < rotacionSuperiorMinima)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotacionSuperiorMinima));
        }
     }
}
