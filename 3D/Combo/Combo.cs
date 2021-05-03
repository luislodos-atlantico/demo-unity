using UnityEngine;

public class Combo : MonoBehaviour
{
    const float tiempoMaximo = 1.0f;
    const int comboMaximo = 2;
    float tiempoUltimoClick = 0;
    int numeroCombo = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (tiempoUltimoClick < tiempoMaximo)
            {
                numeroCombo++;
                if (numeroCombo > comboMaximo)
                {
                    numeroCombo = 0;
                }
            }
            else
            {
                numeroCombo = 0;
            }
            tiempoUltimoClick = 0;
            print(numeroCombo);
        }
        tiempoUltimoClick += Time.deltaTime;
    }
}
