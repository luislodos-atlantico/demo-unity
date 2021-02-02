using UnityEngine;

public class Golpeador : MonoBehaviour
{
    public KeyCode tecla = KeyCode.UpArrow;
    HingeJoint2D junta;

    void Start()
    {
        junta = GetComponent<HingeJoint2D>();
        junta.useMotor = false;
    }

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
