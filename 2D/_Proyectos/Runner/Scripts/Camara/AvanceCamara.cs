using UnityEngine;

public class AvanceCamara : MonoBehaviour
{
    public float velocidad = 10;

    void Update()
    {
        var nuevaPosicion = transform.position;
        nuevaPosicion.x += velocidad * Time.deltaTime;
        transform.position = nuevaPosicion;
    }
}
