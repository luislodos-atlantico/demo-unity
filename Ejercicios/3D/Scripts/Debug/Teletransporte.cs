using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public GameObject teletransportado;
    public Transform[] destino;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            teletransportado.transform.position = destino[0].transform.position;     
        if (Input.GetKeyDown(KeyCode.Alpha2))
            teletransportado.transform.position = destino[1].transform.position;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            teletransportado.transform.position = destino[2].transform.position;
    }
}
