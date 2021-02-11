using UnityEngine;

public class Golpeador : MonoBehaviour
{
    public KeyCode tecla = KeyCode.UpArrow;
    public HingeJoint2D junta;

    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            junta.useMotor = true;
        }
        if (Input.GetKeyUp(tecla))
        {
            junta.useMotor = false;
        }
    }
}
