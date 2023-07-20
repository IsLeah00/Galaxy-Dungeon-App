using UnityEngine;
using TMPro;


public class LightTimer2 : MonoBehaviour
{

    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    public GameObject Countdown;


    void Start()
    {
        Countdown.SetActive(false);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                Countdown.SetActive(true);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                Countdown.SetActive(false);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}", seconds);
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        if (Col.CompareTag("Player2"))
        {
            timerIsRunning = true;
        }
    }
}
