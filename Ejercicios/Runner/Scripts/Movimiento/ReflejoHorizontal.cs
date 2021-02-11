using UnityEngine;

public class ReflejoHorizontal : MonoBehaviour
{
    public SpriteRenderer sprite;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            sprite.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = false;
        }
    }
}
