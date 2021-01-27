using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour
{
    HingeJoint2D junta;
    void Start()
    {
        junta = GetComponent<HingeJoint2D>();
        junta.useMotor = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            junta.useMotor = true;
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            junta.useMotor = false;
        }
    }
}
