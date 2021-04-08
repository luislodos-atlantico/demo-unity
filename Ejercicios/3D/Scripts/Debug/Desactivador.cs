using UnityEngine;

public class Desactivador : MonoBehaviour
{
    public string etiqueta;
    public KeyCode tecla;
    GameObject [] objetos;

    void Start()
    {
        objetos = GameObject.FindGameObjectsWithTag(etiqueta);
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            foreach (GameObject objeto in objetos)
            {
                objeto.SetActive(false);
            }
        }
    }
}
