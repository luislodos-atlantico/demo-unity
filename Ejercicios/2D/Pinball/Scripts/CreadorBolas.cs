using UnityEngine;

public class CreadorBolas : MonoBehaviour
{
    public KeyCode tecla = KeyCode.Space;
    public GameObject bola;

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            Instantiate(bola, transform.position, Quaternion.identity);
        }
    }
}
