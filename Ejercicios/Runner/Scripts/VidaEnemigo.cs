using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public float vida = 50;
    public Animator animador;

    public void Herir(float cantidad)
    {
        vida -= cantidad;
        // animador.SetTrigger("herido");
        if (vida <= 0)
        {
            // animador.SetTrigger("muerto");
            Destroy(gameObject);
        }
    }
}
