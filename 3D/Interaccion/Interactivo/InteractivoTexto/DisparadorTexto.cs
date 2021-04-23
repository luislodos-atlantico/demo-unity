using UnityEngine;

public class DisparadorTexto : Interactivo
{
    [TextArea]
    public string texto;
    PanelTexto panel;

    void Start()
    {
        panel = FindObjectOfType<PanelTexto>();
    }

    public override void Accionar()
    {
        
    }

    public override void Entrar()
    {
        if (panel != null)
        {
            panel.Mostrar(texto);
        }
    }

    public override void Salir()
    {
        if (panel != null)
        {
            panel.Ocultar();
        }
    }
}
