using UnityEngine;
using UnityEngine.AI;

public class MovimientoAgente : MonoBehaviour
{
    NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray posicionClick = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit puntoImpacto;
            bool rayo = Physics.Raycast(posicionClick, out puntoImpacto, 100);
            if (rayo)
            {
                agente.destination = puntoImpacto.point;
            }
        }
    }
}
