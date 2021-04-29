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
    BoxCollider colisionador; // COMPONENTE UNITY
    Text texto; // COMPONENTE UNITY
    float contador = 0; // DECIMAL C#

    // FUNCIONES UNITYENGINE
    void Start()
    {
        animador = GetComponent<Animator>();
        colisionador = GetComponent<BoxCollider>();
        texto = GetComponent<Text>();
    }

    void Update()
    {
        colisionador.isTrigger = false;
        texto.text = nombrePersonaje; // ASIGNACIÓN
        if (texto.text == nombrePersonaje) // COMPARACIÓN
        {
            
        }

        // BLOQUE CONDICIONAL
        if (texto.text == nombrePersonaje) // COMPARACIÓN
        {
            print("Dentro del if");
        }
        else
        {
            print("Dentro del else");
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
