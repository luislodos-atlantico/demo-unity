using UnityEngine;

public class Conmutador : MonoBehaviour
{
    public GameObject objeto;
    bool activo = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (activo == true)
            {
                objeto.SetActive(false);
                activo = false;
            }
            else
            {
                objeto.SetActive(true);
                activo = true;
            }
            // objeto.SetActive(!objeto.activeSelf);
        }
    }
}
