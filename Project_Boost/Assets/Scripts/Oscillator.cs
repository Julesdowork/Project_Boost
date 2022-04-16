using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    const float tau = Mathf.PI * 2;     // ~6.283
    float cycles;
    Vector3 offset;
    
    private Vector3 startingPos;
    [SerializeField] private Vector3 movementVector;
    private float movementFactor;
    [SerializeField] private float period = 2f;

    void Start()
    {
        startingPos = transform.position;
    }

    void Update()
    {
        cycles = Time.time / period;                    // continually growing over time
        float rawSinWave = Mathf.Sin(cycles * tau);     // going from -1 to 1

        movementFactor = (rawSinWave + 1f) / 2f;        // recalculated to go from 0 to 1 so its cleaner

        offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
