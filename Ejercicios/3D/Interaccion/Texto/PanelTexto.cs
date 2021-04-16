using UnityEngine;
using UnityEngine.UI;

public class PanelTexto : MonoBehaviour
{
    Text texto;

    void Start()
    {
        texto = GetComponent<Text>();
        texto.text = "";
    }

    public void Mostrar(string nuevo_texto)
    {
        texto.text = nuevo_texto;
    }

    public void Ocultar()
    {
        texto.text = "";
    }
}
