using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene escenaActual = SceneManager.GetActiveScene();
            SceneManager.LoadScene(escenaActual.name);
        }
    }
}
