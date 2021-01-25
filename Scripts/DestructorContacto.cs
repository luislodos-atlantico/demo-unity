using UnityEngine;

public class DestructorContacto : MonoBehaviour
{
    public GameObject explosion;
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
