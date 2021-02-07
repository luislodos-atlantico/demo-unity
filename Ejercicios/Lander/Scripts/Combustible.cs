using UnityEngine;

public class Combustible : MonoBehaviour
{
    public float cantidad = 100;
    public float consumo = 0.1f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cantidad -= consumo * Time.deltaTime;
        }
    }
}
