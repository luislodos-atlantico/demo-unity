using UnityEngine;
using UnityEngine.UI;

public class TextoContador : MonoBehaviour
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
