using UnityEngine;
using UnityEngine.AI;

public class EnemigoIA : MonoBehaviour
{
    public float distanciaLlegada = 5f;
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
        if (!jugador)
        {
            Patrullar();
            return;
        }
        var distanciaJugador = (jugador.transform.position - transform.position).magnitude;
        if (distanciaJugador < distanciaAtacar)
        {
            Atacar();
        }
        else if (distanciaJugador < distanciaPerseguir)
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
        agente.destination = puntos[puntoActual].position;
        var distanciaPunto = (puntos[puntoActual].position - transform.position).magnitude;
        if (distanciaPunto < distanciaLlegada)
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
        var vida = jugador.GetComponent<Vida>();
        vida.Herir(20 * Time.deltaTime);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaPerseguir);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distanciaAtacar);
    }
}
