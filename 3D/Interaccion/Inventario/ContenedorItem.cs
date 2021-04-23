using UnityEngine;

public class ContenedorItem : Interactivo
{
    public Item item;
    Inventario inventario;

    void Start()
    {
        inventario = FindObjectOfType<Inventario>();
    }

    public override void Accionar()
    {
        if (inventario)
        {
            inventario.Agregar(item);
        }
    }

    public override void Entrar()
    {
        
    }

    public override void Salir()
    {
        
    }
}
