using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject teletransportado;
    PuntoTeletransporte[] puntos;

    void Start()
    {
        puntos = FindObjectsOfType<PuntoTeletransporte>();
    }

    void Update()
    {
        foreach (var punto in puntos)
        {
            if (Input.GetKeyDown(punto.tecla))
            {
                teletransportado.transform.position = punto.transform.position;
                teletransportado.transform.rotation = punto.transform.rotation;
            }
        }    
    }
}
