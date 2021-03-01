using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public Animator animador;
    public float vida = 50;

    public void Herir(float cantidad)
    {
        vida -= cantidad;
        animador.SetTrigger("herir");
        if (vida <= 0)
        {
            animador.SetTrigger("morir");
            Destroy(this);
        }
    }
}
