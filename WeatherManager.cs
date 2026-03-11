using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public Light sun;
    public ParticleSystem rain;

    private bool isRaining = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ToggleRain();
        }
    }

    void ToggleRain()
    {
        isRaining = !isRaining;
        if (isRaining)
        {
            rain.Play();
            sun.intensity = 0.5f;
        }
        else
        {
            rain.Stop();
            sun.intensity = 1.0f;
        }
    }
}
