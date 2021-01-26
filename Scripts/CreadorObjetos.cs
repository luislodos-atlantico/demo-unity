using UnityEngine;

public class CreadorObjetos : MonoBehaviour
{
    public GameObject objeto;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objeto, transform.position, Quaternion.identity);
        }
    }
}
