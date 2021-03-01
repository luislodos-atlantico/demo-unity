using UnityEngine;

public class ReflejoHorizontal : MonoBehaviour
{
    public SpriteRenderer sprite;
    public GameObject areaAtaque;
    Vector3 escala;

    private void Start()
    {
        escala = areaAtaque.transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            sprite.flipX = true;
            var escalaReflejada = transform.localScale;
            escalaReflejada.x = escala.x;
            areaAtaque.transform.localScale = escalaReflejada;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            sprite.flipX = false;
            var escalaReflejada = transform.localScale;
            escalaReflejada.x = -escala.x;
            areaAtaque.transform.localScale = escalaReflejada;
        }
    }
}
