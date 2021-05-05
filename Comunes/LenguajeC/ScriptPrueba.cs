using UnityEngine;
using UnityEngine.UI;

public class ScriptPrueba : MonoBehaviour
{
    // VARIABLES PÚBLICAS
    public float vida = 100.0f; // DECIMAL C#
    public int numeroEnemigos = 5; // ENTERO C#
    public string nombrePersonaje = "Pepe"; // CADENA C#
    public Vector3 direccion; // ESTRUCTURA UNITY 
    public GameObject jugador; // COMPONENTE UNITY 

    // VARIABLES PRIVADAS
    Animator animador; // COMPONENTE UNITY
    Text texto; // COMPONENTE UNITY
    float contador = 0; // DECIMAL C#

    // CONSTANTES
    const float velocidadMaxima = 100.0f;

    // FUNCIONES UNITYENGINE
    void Start()
    {
        animador = GetComponent<Animator>();
        texto = GetComponent<Text>();
    }

    void Update()
    {
        texto.text = nombrePersonaje; // ASIGNACIÓN
      
        // BLOQUE CONDICIONAL
        if (texto.text == nombrePersonaje) // COMPARACIÓN
        {
            print("Dentro del if");
            Atacar();
        }
        else
        {
            print("Dentro del else");
            Morir();
        }
    }

    // FUNCIONES PROPIAS
    void Atacar()
    {
    }

    void Morir()
    {
    }
}
