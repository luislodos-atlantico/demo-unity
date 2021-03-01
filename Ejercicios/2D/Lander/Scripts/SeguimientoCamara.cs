using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Camera camara;
    public Transform objetoSeguido;

    void Update()
    {
        if (objetoSeguido == null)
        {
            return;
        }
        var nuevaPosicion = transform.position;
        nuevaPosicion.x = objetoSeguido.position.x;
        nuevaPosicion.y = objetoSeguido.position.y;
        camara.transform.position = nuevaPosicion;
    }
}
