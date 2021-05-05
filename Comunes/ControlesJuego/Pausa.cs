using UnityEngine;

public class Pausa : MonoBehaviour
{
    public bool enPausa = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (enPausa)
            {
                Time.timeScale = 1;
                enPausa = false;
            }
            else
            {
                Time.timeScale = 0;
                enPausa = true;
            }
        }
    }
}
