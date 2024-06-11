using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinishLine : MonoBehaviour
{
    public CarLapCounter carLapCounter;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            carLapCounter.IncrementLap();
        }
    }
}
