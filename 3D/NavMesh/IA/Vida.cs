using UnityEngine;

public class Vida : MonoBehaviour
{
    float puntosVida = 100;
    Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();
    }

    public void Herir()
    {
        animador.SetTrigger("herido");
        puntosVida -= 1.0f;
    }
}
