using UnityEngine;

public class Inventario : MonoBehaviour
{
    public Item[] items = new Item[10];

    public void Agregar(Item nuevoItem)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = nuevoItem;
                return;
            }
        }       
    }

    public void Eliminar(Item itemEliminado)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemEliminado)
            {
                items[i] = null;
                return;
            }
        }
    }
}
