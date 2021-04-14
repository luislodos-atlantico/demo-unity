using UnityEngine;

public class EsferaInteractiva : Interactivo
{
    Material material;
    Color colorInicial;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        colorInicial = material.color;
    }

    public override void Entrar()
    {
        material.color = Color.red;
    }

    public override void Accionar()
    {
        material.color = Color.green;
    }

    public override void Salir()
    {
        material.color = colorInicial;
    }
}
