using UnityEngine;
using UnityEngine.AI;

public class EnemigoIA : MonoBehaviour
{
    const float DISTANCIA_LLEGADA = 5f;
    public float distanciaPerseguir = 15;
    public float distanciaAtacar = 2;
    public Transform[] puntos;
    int puntoActual = 0;
    NavMeshAgent agente;
    GameObject jugador;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        jugador = GameObject.Find("Jugador");
    }

    void Update()
    {
        var distancia = (jugador.transform.position - transform.position).magnitude;
        if (distancia < distanciaAtacar)
        {
            Atacar();
        }
        else if (distancia < distanciaPerseguir)
        {
            Perseguir();
        }
        else
        {
            Patrullar();
        }
    }

    void Patrullar()
    {
        print(puntoActual);
        agente.destination = puntos[puntoActual].position;
        var distanciaPunto = (puntos[puntoActual].position - transform.position).magnitude;
        if (distanciaPunto < DISTANCIA_LLEGADA)
        {
            if (puntoActual < puntos.Length - 1)
            {
                puntoActual++;
            }
            else
            {
                puntoActual = 0;
            }
        }
    }

    void Perseguir()
    {
        agente.destination = jugador.transform.position;
    }

    void Atacar()
    {
        print("Atacar");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaPerseguir);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distanciaAtacar);
    }
}
