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
        if (Input.GetMouseButtonUp(0))
        {
            sprite.color = nuevoColor;
        }
    }
}
