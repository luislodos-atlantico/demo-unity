using UnityEngine;
using UnityEngine.UI;

public class TextoContadorBolas : MonoBehaviour
{
    public ReceptorBolas receptor;
    public Text texto;

    void Update()
    {
        texto.text = "Contador: " + receptor.numeroBolas.ToString();
    }
}
