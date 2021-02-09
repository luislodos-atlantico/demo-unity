using UnityEngine;
using UnityEngine.UI;

public class TextoContadorBolas : MonoBehaviour
{
    public ReceptorBolas receptor;
    Text texto;

    void Start()
    {
        texto = GetComponent<Text>();
    }

    void Update()
    {
        texto.text = "Contador: " + receptor.numeroBolas.ToString();
    }
}
