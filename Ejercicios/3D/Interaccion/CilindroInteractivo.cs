using UnityEngine;

public class CilindroInteractivo : Interactivo
{
    public override void Entrar()
    {
        print("Cilindro cerca");
    }

    public override void Accionar()
    {
        print("Cilindro accionado");
    }

    public override void Salir()
    {
        print("Cilindro lejos");
    }
}
