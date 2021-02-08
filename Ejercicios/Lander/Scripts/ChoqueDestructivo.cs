using UnityEngine;

public class ChoqueDestructivo : MonoBehaviour
{
    public float velocidadDestruccion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var velocidadColision = collision.relativeVelocity.magnitude;
        Debug.Log(velocidadColision);
        if (velocidadColision > velocidadDestruccion)
        {
            Destroy(gameObject);
        }
    }
}
git