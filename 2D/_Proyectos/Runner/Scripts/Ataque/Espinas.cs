using UnityEngine;

public class Espinas : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        var objetoEntrante = collision.gameObject;
        if (objetoEntrante.name == "Jugador")
        {
            Destroy(objetoEntrante);
        }
    }
}
