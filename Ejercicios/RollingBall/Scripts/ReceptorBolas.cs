using UnityEngine;

public class ReceptorBolas : MonoBehaviour
{
    public int numeroBolas = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        numeroBolas++;
        var bola = collision.gameObject;
        Destroy(bola);
    }
}
