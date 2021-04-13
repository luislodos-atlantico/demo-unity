using UnityEngine;

public abstract class LuzInteractiva : Interactivo
{
    public override void Accionar()
    {
        print("Luz");
    }

    public override void Resaltar(bool valor)
    {
        print("Puerta");
    }
}
