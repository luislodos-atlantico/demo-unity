using UnityEngine;

public class LimiteJugador : MonoBehaviour
{
    public Transform limite;

    void Update()
    {
        if (transform.position.x < limite.position.x)
        {
            var posicionLimitada = transform.position;
            posicionLimitada.x = limite.position.x;
            transform.position = posicionLimitada;
        }
    }
}
