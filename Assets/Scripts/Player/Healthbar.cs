using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider HealthSlider; 

    public void SetMaxHealth(int health)
    {
        HealthSlider.maxValue = health;
        HealthSlider.value = health;
    }
    public void SetHealth(int health)
    {
        HealthSlider.value = health;
    }
}
