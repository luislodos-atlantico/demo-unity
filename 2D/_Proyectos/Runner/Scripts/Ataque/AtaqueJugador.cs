using UnityEngine;

public class AtaqueJugador : MonoBehaviour
{
    public Animator animador;
    public float fuerza = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animador.SetTrigger("atacar");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var vidaEnemigo = collision.GetComponent<VidaEnemigo>();
        if (vidaEnemigo != null)
        {
            vidaEnemigo.Herir(fuerza);
        }
    }
}