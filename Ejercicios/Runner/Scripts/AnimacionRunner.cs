using UnityEngine;

public class AnimacionRunner : MonoBehaviour
{
    public Animator animador;

    private void Update()
    {
        animador.SetBool("corriendo", true);
                
        if (Input.GetKeyDown(KeyCode.W))
        {
            animador.SetTrigger("saltar");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animador.SetTrigger("atacar");
        }
    }
}
