using UnityEngine;

public class DetectorJugador : MonoBehaviour
{
    public bool jugadorDetectado;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Jugador")
        {
            jugadorDetectado = true;
        }
    }
}
