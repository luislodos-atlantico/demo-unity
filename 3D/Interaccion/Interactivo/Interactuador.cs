using UnityEngine;

public class Interactuador : MonoBehaviour
{
    public KeyCode tecla = KeyCode.E;
    bool teclaPulsada;

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            teclaPulsada = true;
        }
    }

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
        if (teclaPulsada)
        {
            var interactivo = other.GetComponent<Interactivo>();
            if (interactivo != null)
            {
                interactivo.Accionar();
            }
            teclaPulsada = false;
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
