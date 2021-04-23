using UnityEngine;
using UnityEngine.UI;

public class BarraCombustible : MonoBehaviour
{
    public Combustible combustible;
    public Image imagen;

    private void Update()
    {
        imagen.fillAmount = combustible.cantidad / 100;
    }
}
