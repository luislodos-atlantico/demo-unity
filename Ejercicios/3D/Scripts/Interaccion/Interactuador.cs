using UnityEngine;

public class Interactuador : MonoBehaviour
{
    public KeyCode tecla;

    void OnTriggerStay(Collider other)
    {
        var interactivo = other.GetComponent<Interactivo>();
        if (interactivo != null)
        {
            interactivo.Accionar();
        }
    }
}
