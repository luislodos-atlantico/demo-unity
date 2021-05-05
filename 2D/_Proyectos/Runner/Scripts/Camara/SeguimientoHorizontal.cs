using UnityEngine;

public class SeguimientoHorizontal : MonoBehaviour
{
    public Transform objetoSeguido;
    Vector2 desfaseInicial;
    Vector2 posicionAnterior;

    private void Start()
    {
        desfaseInicial = objetoSeguido.position - transform.position;
        posicionAnterior = transform.position;
    }

    void Update()
    {
        if (objetoSeguido == null)
        {
            return;
        }
        var nuevaPosicion = transform.position;
        nuevaPosicion.x = objetoSeguido.transform.position.x - desfaseInicial.x;
        if (nuevaPosicion.x > posicionAnterior.x)
        {
            transform.position = nuevaPosicion;
            posicionAnterior = transform.position;
        }
    }
}
