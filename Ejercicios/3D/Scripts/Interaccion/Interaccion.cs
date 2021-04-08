using UnityEngine;

public class Interaccion : MonoBehaviour
{
    public Animator animador;
    public string animacion;
    public KeyCode tecla;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(tecla))
            {
                animador.Play(animacion);
            }
        }
    }
}
