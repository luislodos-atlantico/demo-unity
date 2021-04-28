using UnityEngine;

public class RayoInteractuador : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray posicionClick = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit puntoImpacto;
            bool rayo = Physics.Raycast(posicionClick, out puntoImpacto, 100);
            if (rayo)
            {
                var interactivo = puntoImpacto.collider.GetComponent<Interactivo>();
                if (interactivo)
                {
                    interactivo.Accionar();
                }
            }
        }
    }
}
