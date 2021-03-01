using UnityEngine;

public class GiroLander : MonoBehaviour
{
    public Rigidbody2D cuerpo;
    public float torque = 10;

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
