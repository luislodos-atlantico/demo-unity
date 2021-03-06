using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadAvance = 5;
    public float velocidadCaida = 0.1f;
    public float velocidadSalto = 10;
    CharacterController controlador;
    Vector3 direccionMovimiento = Vector3.zero;

    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        // MOVIMIENTO AVANZAR Y RETROCEDER
        var direccionAvanzar = Input.GetAxis("Vertical") * Time.deltaTime * Vector3.forward;
        var direccionRelativa = transform.TransformDirection(direccionAvanzar);
        direccionMovimiento.x = direccionRelativa.x * velocidadAvance;
        direccionMovimiento.z = direccionRelativa.z * velocidadAvance;

        // SALTO
        if (Input.GetButtonDown("Jump") && controlador.isGrounded)
        {
            direccionMovimiento.y = velocidadSalto * Time.deltaTime;
        }
        else
        {
            direccionMovimiento.y -= velocidadCaida * Time.deltaTime;
        }
        
        // MOVIMIENTO
        controlador.Move(direccionMovimiento);
    }
}
