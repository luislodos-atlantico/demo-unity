using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour
{
    public GameObject objeto;
    public float tiempoCreacionMinimo = 1;
    public float tiempoCreacionMaximo = 3;
    float contador;
    float tiempoCreacion;

    private void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoCreacion)
        {
            Instantiate(objeto, transform.position, transform.rotation);
            tiempoCreacion = Random.Range(tiempoCreacionMinimo, tiempoCreacionMaximo);
            contador = 0;
        }
    }

}
