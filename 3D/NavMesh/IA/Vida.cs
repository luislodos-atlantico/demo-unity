using UnityEngine;

public class Vida : MonoBehaviour
{
    float puntosVida = 100;
    Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();
    }

    public void Herir(float cantidad)
    {
        animador.SetTrigger("herido");
        puntosVida -= cantidad;
        if (puntosVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
