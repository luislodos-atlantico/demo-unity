using UnityEngine;

public class Vida : MonoBehaviour
{
    Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();
    }

    public void Herir()
    {
        animador.SetTrigger("herido");
    }
}
