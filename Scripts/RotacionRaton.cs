using UnityEngine;

public class RotacionRaton : MonoBehaviour
{
    public float velocidad = 1;
    public float rotacionSuperior = 60;
    public float rotacionInferior = 350;
    public GameObject pivote;

    void Update()
    {
        // Rotar
        var posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var objetivoX = posicionRaton.x;
        var objetivoY = posicionRaton.y;
        var objetivoZ = 0;
        var objetivo = new Vector3(objetivoX, objetivoY, objetivoZ);
        pivote.transform.right = objetivo - transform.position;

        // Limitar rotación
        var rotacionZ = transform.rotation.eulerAngles.z;
        if (rotacionZ > rotacionSuperior && rotacionZ < 180)
        {
            var rotacionFinal = new Vector3(0, 0, rotacionSuperior);
            pivote.transform.rotation = Quaternion.Euler(rotacionFinal);
        }
        else if (rotacionZ > 180 && rotacionZ < rotacionInferior)
        {
            var rotacionFinal = new Vector3(0, 0, rotacionInferior);
            pivote.transform.rotation = Quaternion.Euler(rotacionFinal);
        }
    }
}