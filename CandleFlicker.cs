using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleFlicker : MonoBehaviour
{
    //created by chatgpt
    
    // The point light that will flicker
    public Light pointLight;

    // The minimum and maximum intensity of the light
    public float minIntensity = 0.25f;
    public float maxIntensity = 0.5f;

    // The amount of time it takes for the light to transition from the minimum intensity to the maximum intensity
    public float minTime = 0.2f;
    public float maxTime = 0.5f;

    // The timer for the current intensity transition
    private float timer;

    // The current target intensity of the light
    private float targetIntensity;

    void Start()
    {
        // Set the timer to a random value between the minimum and maximum transition times
        timer = Random.Range(minTime, maxTime);

        // Set the target intensity to a random value between the minimum and maximum intensities
        targetIntensity = Random.Range(minIntensity, maxIntensity);
    }

    void Update()
    {
        // Decrement the timer by the delta time
        timer -= Time.deltaTime;

        // If the timer has reached zero, it's time to transition to the new target intensity
        if (timer <= 0)
        {
            // Reset the timer to a random value between the minimum and maximum transition times
            timer = Random.Range(minTime, maxTime);

            // Set the new target intensity to a random value between the minimum and maximum intensities
            targetIntensity = Random.Range(minIntensity, maxIntensity);
        }

        // Lerp the light's intensity to the target intensity
        pointLight.intensity = Mathf.Lerp(pointLight.intensity, targetIntensity, Time.deltaTime);
    }
}
