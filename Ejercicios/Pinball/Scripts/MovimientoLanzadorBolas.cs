using UnityEngine;

public class MovimientoLanzadorBolas : MonoBehaviour
{
    public float velocidad = 10;

    void Update()
    {
        var nuevaPosicion = transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            nuevaPosicion.x += velocidad * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            nuevaPosicion.x -= velocidad * Time.deltaTime;
        }
        transform.position = nuevaPosicion;
    }
}
