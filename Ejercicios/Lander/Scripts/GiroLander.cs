using UnityEngine;

public class GiroLander : MonoBehaviour
{
    public float torque = 10;
    Rigidbody2D cuerpo;

    private void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddTorque(torque);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddTorque(-torque);
        }
    }

}
