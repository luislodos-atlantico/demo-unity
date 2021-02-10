using UnityEngine;

public class GeneradorPlataformas : MonoBehaviour
{
    public GameObject plataforma;
    public DetectorJugador detector;

    void Update()
    {
        if (detector.jugadorDetectado == true)
        {
            var plataformaCreada = Instantiate(plataforma, transform.position, transform.rotation);
            detector = plataformaCreada.GetComponentInChildren<DetectorJugador>();
            detector.jugadorDetectado = false;
        }
    }
}
