using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public CharacterController controlador;
    public float velocidadMovimiento = 5;
    public float velocidadRotacion = 100;
    public float velocidadCaida = -1;

    void Update()
    {
        // MOVIMIENTO
        var direccion = Vector3.zero;
        direccion.z = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        direccion.y += velocidadCaida * Time.deltaTime;
        var direccionRelativa = transform.TransformDirection(direccion);
        controlador.Move(direccionRelativa * velocidadMovimiento);

        // ROTACIÓN
        var rotacion = Vector3.zero;
        rotacion.y = Input.GetAxisRaw("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(rotacion);
    }
}
