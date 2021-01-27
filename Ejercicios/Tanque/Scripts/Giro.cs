using UnityEngine;

public class Giro : MonoBehaviour
{
    public float torque = 1;
    Rigidbody2D cuerpo;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddTorque(-torque);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddTorque(torque);
        }
    }
}
