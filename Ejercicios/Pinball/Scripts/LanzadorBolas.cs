using UnityEngine;

public class LanzadorBolas : MonoBehaviour
{
    public GameObject bola;
    public KeyCode tecla = KeyCode.Return;
    public float fuerzaMinima = 5;
    public float multiplicadorFuerza = 10;
    float tiempoApretando = 0;

    void Update()
    {
        if (Input.GetKey(tecla))
        {
            tiempoApretando += Time.deltaTime;
        }
        if (Input.GetKeyUp(tecla))
        {
            var bolaCreada = Instantiate(bola, transform.position, Quaternion.identity);
            var cuerpoBola = bolaCreada.GetComponent<Rigidbody2D>();
            var fuerzaAplicada = fuerzaMinima + multiplicadorFuerza * tiempoApretando;
            cuerpoBola.AddForce(fuerzaAplicada * Vector2.up, ForceMode2D.Impulse);
            tiempoApretando = 0;
        }
    }
}
