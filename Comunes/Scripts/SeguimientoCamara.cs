using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Camera camara;
    public GameObject objetoSeguido;

    void Update()
    {
        if (objetoSeguido == null)
            return;
        var x = objetoSeguido.transform.position.x;
        var y = objetoSeguido.transform.position.y;
        var z = camara.transform.position.z;
        camara.transform.position = new Vector3(x, y, z);
    }
}
