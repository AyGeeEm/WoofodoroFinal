using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    public Text timerText; // Reference to the UI Text object that displays the timer

    private float timer = 25 * 60; // The starting time of the timer in seconds (25 minutes)

    public bool isRunning = false;

    // Update is called once per frame
    void Update()
    {
        UpdateTimerText();
        if (isRunning){
            // If the timer is still running, count down
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                // Update the timer text to display the remaining time in minutes and seconds
                UpdateTimerText();
            }
            if (timer <= 0){
                timer = 0f;
                StopTimer();
            }
        }
    }

    public void StartTimer(){
        isRunning = true;
    }

    private void StopTimer(){
        isRunning = false;
    }

    public void ResetTimer(){
        timer = 25 * 60;
        UpdateTimerText();
        isRunning = false;
    }

    // Updates the timer text to display the remaining time in minutes and seconds
    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
