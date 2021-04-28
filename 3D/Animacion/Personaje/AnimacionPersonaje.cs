using UnityEngine;

public class AnimacionPersonaje : MonoBehaviour
{
    Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            animador.SetBool("caminando", true);
        }
        else
        {
            animador.SetBool("caminando", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animador.SetTrigger("atacar");
        }
    }
}
