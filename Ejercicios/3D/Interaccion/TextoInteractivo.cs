using UnityEngine;

public class TextoInteractivo : Interactivo
{
    [TextArea]
    public string texto;

    public override void Accionar()
    {
        print(texto);
    }

    public override void Entrar()
    {
        
    }

    public override void Salir()
    {
        
    }
}
