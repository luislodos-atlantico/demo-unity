using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadAvance = 5;
    public float velocidadRotacion = 100;
    public float velocidadCaida = 0.1f;
    public float velocidadSalto = 10;
    public float sensibilidad_raton = 100;
    CharacterController controlador;
    Vector3 direccionMovimiento = Vector3.zero;
    Vector3 rotacion_raton = Vector3.zero;

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

        // ROTACIÓN CON TECLADO
        var rotacion_teclado = Vector3.zero;
        rotacion_teclado.y = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(rotacion_teclado);

        // ROTACIÓN CON RATÓN
        /*
        rotacion_raton.y += Input.GetAxis("Mouse X") * sensibilidad_raton * Time.deltaTime;
        rotacion_raton.z = 0;
        transform.rotation = Quaternion.Euler(rotacion_raton);
        */
    }
}
