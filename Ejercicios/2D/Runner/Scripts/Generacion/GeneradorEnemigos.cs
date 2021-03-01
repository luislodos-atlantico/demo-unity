using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject enemigo;
    public float tiempoCreacionMinimo = 1;
    public float tiempoCreacionMaximo = 3;
    float tiempoCreacion;
    float contador;

    private void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoCreacion)
        {
            Instantiate(enemigo, transform.position, transform.rotation);
            tiempoCreacion = Random.Range(tiempoCreacionMinimo, tiempoCreacionMaximo);
            contador = 0;
        }
    }
}