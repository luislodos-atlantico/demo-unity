using UnityEngine;

public class AnimacionBandido : MonoBehaviour
{
    public Animator animador;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            animador.SetBool("corriendo", true);
        }
        else
        {
            animador.SetBool("corriendo", false);
        }

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
