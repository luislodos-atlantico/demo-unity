using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public CharacterController controlador;
    public float velocidadMovimiento = 5;
    public float velocidadRotacion = 100;
    public float velocidadCaida = -1;
    public float sensibilidad_raton = 100;
    Vector3 rotacion_raton = Vector3.zero;

    void Update()
    {
        // MOVIMIENTO AVANZAR Y RETROCEDER
        var direccion_avanzar = Vector3.zero;
        direccion_avanzar.z = Input.GetAxis("Vertical") * Time.deltaTime;
        var direccionRelativa = transform.TransformDirection(direccion_avanzar);
        controlador.Move(direccionRelativa * velocidadMovimiento);

        // MOVIMIENTO LATERAL
        var direccion_lateral = Vector3.zero;
        direccion_lateral.x = Input.GetAxis("Horizontal") * Time.deltaTime;
        direccionRelativa = transform.TransformDirection(direccion_lateral);
        controlador.Move(direccionRelativa * velocidadMovimiento);

        // CAÍDA
        var direccion_caida = Vector3.zero;
        direccion_caida.y += velocidadCaida * Time.deltaTime;
        direccionRelativa = transform.TransformDirection(direccion_caida);
        controlador.Move(direccionRelativa * velocidadMovimiento);

        // ROTACIÓN CON TECLADO
        /*
        var rotacion_teclado = Vector3.zero;
        rotacion_teclado.y = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(rotacion_teclado);
        */

        // ROTACIÓN CON RATÓN
        rotacion_raton.y += Input.GetAxis("Mouse X") * sensibilidad_raton * Time.deltaTime;
        rotacion_raton.z = 0;
        transform.rotation = Quaternion.Euler(rotacion_raton);
    }
}
