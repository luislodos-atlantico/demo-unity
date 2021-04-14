using UnityEngine;

public class ManagerGrupo : MonoBehaviour
{
    Item[] items;

    void Start()
    {
        items = FindObjectsOfType<Item>();
    }

    void Update()
    {
        foreach (var item in items)
        {
            print(item.name);
        }
    }
}
