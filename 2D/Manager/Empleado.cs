using UnityEngine;

public class Empleado : MonoBehaviour
{
    public Manager manager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            manager.variableCompartida = 10;
        }
    }
}
