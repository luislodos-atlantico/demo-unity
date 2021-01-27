using UnityEngine;

public class LanzadorBolas : MonoBehaviour
{
    public GameObject bola;
    public float fuerzaInicial = 10;
    float tiempoApretando = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            tiempoApretando += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var bolaCreada = Instantiate(bola, transform.position, Quaternion.identity);
            var cuerpoBola = bolaCreada.GetComponent<Rigidbody2D>();
            cuerpoBola.AddForce (fuerzaInicial * tiempoApretando * Vector2.up, ForceMode2D.Impulse);
            tiempoApretando = 0;
        }
    }
}
