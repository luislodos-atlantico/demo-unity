using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public Color nuevoColor = Color.red;
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            sprite.color = nuevoColor;
        }
    }
}
