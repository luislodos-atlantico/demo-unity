using UnityEngine;

public class EfectoContacto : MonoBehaviour
{
    public ParticleSystem particulas;
    AudioSource fuenteSonido;
    Animator animador;

    void Start()
    {
        particulas.Stop();
        fuenteSonido = GetComponent<AudioSource>();
        animador = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        particulas.Play();
        fuenteSonido.Play();
        animador.Play("CambioColor");
    }
}
