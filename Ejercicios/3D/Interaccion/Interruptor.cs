using UnityEngine;

public class Interruptor : Interactivo
{
    public GameObject puerta;

    public override void Accionar()
    {
        puerta.SetActive(!puerta.activeSelf);
    }

    public override void Entrar()
    {
        
    }

    public override void Salir()
    {
        
    }
}
