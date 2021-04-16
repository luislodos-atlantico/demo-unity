using UnityEngine;

public class Interactuador : MonoBehaviour
{
    public KeyCode tecla = KeyCode.E;

    void OnTriggerEnter(Collider other)
    {
        var interactivo = other.GetComponent<Interactivo>();
        if (interactivo != null)
        {
            interactivo.Entrar();
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

    void OnTriggerExit(Collider other)
    {
        var interactivo = other.GetComponent<Interactivo>();
        if (interactivo != null)
        {
            interactivo.Salir();
        }
    }
}
