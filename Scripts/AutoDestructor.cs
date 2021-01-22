using UnityEngine;

public class AutoDestructor : MonoBehaviour
{
    public float tiempo = 3;
    float tiempoRestante;

    private void Start()
    {
        tiempoRestante = tiempo;
    }

    void Update()
    {
        tiempoRestante -= Time.deltaTime;
        if (tiempoRestante <= 0)
        {
            Destroy(gameObject);
        }
    }
}
