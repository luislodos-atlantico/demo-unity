using UnityEngine;

public class Combustible : MonoBehaviour
{
    public float combustible = 100;
    public float consumo = 0.1f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            combustible -= consumo * Time.deltaTime;
        }
    }
}
