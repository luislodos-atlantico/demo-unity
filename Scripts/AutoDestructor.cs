using UnityEngine;

public class AutoDestructor : MonoBehaviour
{
    public float tiempoTotal = 3;
    float tiempoRestante;

    private void Start()
    {
        tiempoRestante = tiempoTotal;
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
