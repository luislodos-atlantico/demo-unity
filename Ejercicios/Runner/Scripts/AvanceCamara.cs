using UnityEngine;

public class AvanceCamara : MonoBehaviour
{
    public float velocidad = 10;

    private void Update()
    {
        MovimientoSolucion1();        
    }

    void MovimientoSolucion1()
    {
        var x = transform.position.x + velocidad * Time.deltaTime;
        var y = transform.position.y;
        var z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }

    void MovimientoSolucion2()
    {
        var nuevaPosicion = transform.position;
        nuevaPosicion.x += velocidad * Time.deltaTime;
        transform.position = nuevaPosicion;
    }
}
