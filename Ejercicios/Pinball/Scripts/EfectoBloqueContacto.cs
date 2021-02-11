using UnityEngine;

public class EfectoBloqueContacto : MonoBehaviour
{
    public ParticleSystem particulas;
    public AudioSource fuenteSonido;
    public Animator animador;

    void Start()
    {
        particulas.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        particulas.Play();
        fuenteSonido.Play();
        animador.Play("CambioColor");
    }
}
