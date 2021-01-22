using UnityEngine;

public class LanzadorProyectiles : MonoBehaviour
{
    public GameObject bala;
    public GameObject origenDisparo;
    public float impulsoBala = 10;
    public KeyCode teclaDisparo = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(teclaDisparo))
        {
            var posicion = origenDisparo.transform.position;
            var rotacion = origenDisparo.transform.rotation;
            var balaCreada = Instantiate(bala, posicion, rotacion);
            var cuerpoBala = balaCreada.GetComponent<Rigidbody2D>();
            var distancia = origenDisparo.transform.position - transform.position;
            var direccion = distancia.normalized;
            cuerpoBala.AddForce(impulsoBala * direccion, ForceMode2D.Impulse);
        }
    }
}
