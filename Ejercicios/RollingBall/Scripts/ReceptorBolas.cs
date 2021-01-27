using UnityEngine;

public class ReceptorBolas : MonoBehaviour
{
    public int bolas = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bolas++;
        var bola = collision.gameObject;
        Destroy(bola);
    }
}
