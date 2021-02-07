using UnityEngine;

public class ParticulasPropulsor : MonoBehaviour
{
    public ParticleSystem particulas;
    public KeyCode tecla;
    public Combustible combustible;

    private void Start()
    {
        particulas.Stop();
    }

    void Update()
    {
        if (combustible.cantidad <= 0)
        {
            particulas.Stop();
            return;
        }
        if (Input.GetKeyDown(tecla))
        {
            particulas.Play();
        }
        if (Input.GetKeyUp(tecla))
        {
            particulas.Stop();
        }
    }
}
