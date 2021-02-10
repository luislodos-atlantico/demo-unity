using UnityEngine;

public class LimiteJugador : MonoBehaviour
{
    public Transform limite;

    void Update()
    {
        if (transform.position.x < limite.position.x)
        {
            var x = limite.position.x;
            var y = transform.position.y;
            var z = transform.position.z;
            transform.position = new Vector3(x, y, z);
        }
            

    }
}
