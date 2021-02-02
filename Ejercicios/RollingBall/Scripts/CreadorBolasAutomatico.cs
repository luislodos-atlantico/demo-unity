using UnityEngine;

public class CreadorBolasAutomatico : MonoBehaviour
{
    public GameObject bola;
    public float tiempoCreacion = 2;
    float contador;

    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoCreacion)
        {
            Instantiate(bola, transform.position, Quaternion.identity);
            contador = 0;
        }
    }
}
