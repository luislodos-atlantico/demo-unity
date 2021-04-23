using UnityEngine;

public class LanzadorProyectiles : MonoBehaviour
{
    public GameObject bala;
    public GameObject origenDisparo;
    public KeyCode teclaDisparo = KeyCode.Space;
    public float impulsoBala = 10;

    void Update()
    {
        if (Input.GetKeyDown(teclaDisparo))
        {
            // Creación
            var posicion = origenDisparo.transform.position;
            var rotacion = origenDisparo.transform.rotation;
            var balaCreada = Instantiate(bala, posicion, rotacion);

            // Impulso
            var cuerpoBala = balaCreada.GetComponent<Rigidbody2D>();
            var distancia = origenDisparo.transform.position - transform.position;
            var direccion = distancia.normalized;
            cuerpoBala.AddForce(impulsoBala * direccion, ForceMode2D.Impulse);
        }
    }
}
