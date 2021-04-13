using UnityEngine;

public class EsferaInteractiva : Interactivo
{
    public override void Accionar()
    {
        print("Esfera accionada");
    }

    public override void Resaltar(bool valor)
    {
        if (valor)
            print("Esfera cerca");
        else
            print("Esfera lejos");
    }
}
