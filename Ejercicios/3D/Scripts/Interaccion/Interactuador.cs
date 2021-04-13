using UnityEngine;

public class Interactuador : MonoBehaviour
{
    public KeyCode tecla;

    void OnTriggerEnter(Collider other)
    {
        var interactivo = other.GetComponent<Interactivo>();
        if (interactivo != null)
        {
            interactivo.Resaltar(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        var interactivo = other.GetComponent<Interactivo>();
        if (interactivo != null)
        {
            interactivo.Resaltar(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(tecla))
        {
            var interactivo = other.GetComponent<Interactivo>();
            if (interactivo != null)
            {
                interactivo.Accionar();
            }
        }
    }
}
