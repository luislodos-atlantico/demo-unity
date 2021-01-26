using UnityEngine;

public class CambioPosicionHorizontal : MonoBehaviour
{
    public float velocidad = 1;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            var x = transform.position.x + velocidad * Time.deltaTime;
            var y = transform.position.y;
            transform.position = new Vector2(x, y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            var x = transform.position.x - velocidad * Time.deltaTime;
            var y = transform.position.y;
            transform.position = new Vector2(x, y);
        }
    }
}
