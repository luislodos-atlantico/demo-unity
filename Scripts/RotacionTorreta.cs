using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTorreta : MonoBehaviour
{
    public float velocidad = 1;
    public float rotacionSuperior = 60;
    public float rotacionInferior = 350;

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
        var rotacionZ = transform.rotation.eulerAngles.z;

        if (rotacionZ > rotacionSuperior && rotacionZ < 180)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotacionSuperior));
        }
        else if (rotacionZ > 180 && rotacionZ < rotacionInferior)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotacionInferior));
        }
     }
}
