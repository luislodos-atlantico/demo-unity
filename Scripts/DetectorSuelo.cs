using UnityEngine;

public class DetectorSuelo : MonoBehaviour
{
    public bool enSuelo = false;

    private void OnTriggerEnter2D(Collider2D colisionador)
    {
        enSuelo = true;
    }

    private void OnTriggerStay2D(Collider2D colisionador)
    {
        enSuelo = true;
    }

    private void OnTriggerExit2D(Collider2D colisionador)
    {
        enSuelo = false;
    }
}
