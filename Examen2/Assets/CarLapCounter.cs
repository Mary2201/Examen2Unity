using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarLapCounter : MonoBehaviour
{
    public int laps = 0; // Contador de vueltas
    public Text lapText; // Referencia al UI Text

    void Start()
    {
        UpdateLapText();
    }

    public void IncrementLap()
    {
        laps++;
        UpdateLapText();
    }

    void UpdateLapText()
    {
        lapText.text = "Laps: " + laps;
    }
}
