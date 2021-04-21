using UnityEngine;
using UnityEngine.AI;

public class EnemigoIA : MonoBehaviour
{
    public float distanciaPerseguir = 100;
    public float distanciaAtacar = 1;
    public Transform[] puntos;
    int puntoActual = 0;
    GameObject jugador;
    NavMeshAgent agente;

    void Start()
    {
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

    }

    void Perseguir()
    {
        agente.destination = jugador.transform.position;
    }

    void Atacar()
    {
        print("Atacar");
    }
}
