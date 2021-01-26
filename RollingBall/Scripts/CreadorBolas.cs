using UnityEngine;

public class CreadorBolas : MonoBehaviour
{
    public GameObject bola;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bola, transform.position, Quaternion.identity);
        }       
    }
}
