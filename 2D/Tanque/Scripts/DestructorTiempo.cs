using UnityEngine;

public class DestructorTiempo : MonoBehaviour
{
    public float tiempo = 3;

    void Update()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            Destroy(gameObject);
        }
    }
}
