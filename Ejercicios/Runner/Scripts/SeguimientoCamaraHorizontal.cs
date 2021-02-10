using UnityEngine;

public class SeguimientoCamaraHorizontal : MonoBehaviour
{
    public GameObject seguido;
    public float desfaseHorizontal;
    Vector3 posicionAnterior;

    private void Start()
    {
        posicionAnterior = transform.position;
    }

    void Update()
    {
        if (seguido == null)
            return; 
        var x = seguido.transform.position.x + desfaseHorizontal;
        var y = transform.position.y;
        var z = transform.position.z;
        var nuevaPosicion = new Vector3(x, y, z);

        if (nuevaPosicion.x > posicionAnterior.x)
        {
            transform.position = nuevaPosicion;
            posicionAnterior = transform.position;
        }
    }
}
