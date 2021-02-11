using UnityEngine;

public class Ataque : MonoBehaviour
{
    public float fuerza = 10;
    public Animator animador;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animador.SetTrigger("atacar");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var vidaEnemigo = collision.GetComponent<VidaEnemigo>();
        if (vidaEnemigo != null)
        {
            vidaEnemigo.Herir(fuerza);
        }
    }
}
