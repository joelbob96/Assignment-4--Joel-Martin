using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timeRemaining;
    public int livesRemaining;
    public Text DisplayTime;
    public Text DisplayLives;
    


    void Start()
    {
        timeRemaining = Timedropdown.SelectedTime;
        Pin.livesRemaining = Livesdropdown.lives;
    }
    // Update is called once per frame
    void Update()
    {
        if(timeRemaining >= 1)
        {
            livesRemaining = Pin.livesRemaining;
            timeRemaining -= Time.deltaTime;
            DisplayTime.text = "Time Remaining: " + Mathf.FloorToInt(timeRemaining).ToString();
            DisplayLives.text = "Lives" + livesRemaining.ToString();
        }
        else
        {
            FindObjectOfType<MyGameManager>().EndGame();
        }
    }
}
