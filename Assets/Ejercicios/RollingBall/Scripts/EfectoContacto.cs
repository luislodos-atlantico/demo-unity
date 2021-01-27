using UnityEngine;

public class EfectoContacto : MonoBehaviour
{
    public ParticleSystem particulas;

    void Start()
    {
        particulas.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        particulas.Play();
    }
}
