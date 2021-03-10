using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPrefs : MonoBehaviour
{
    public void LoadP()
    {
        if (PlayerPrefs.HasKey("PinSpeed"))
        {
            Pin.speed = PlayerPrefs.GetFloat("PinSpeed");
        }
        if (PlayerPrefs.HasKey("RotatorSpeed"))
        {
            Rotator.Speed = PlayerPrefs.GetFloat("RotatorSpeed");
        }
        if (PlayerPrefs.HasKey("TimeRemaining"))
        {
            Timer.timeRemaining = PlayerPrefs.GetFloat("TimeRemaining");
        }
        if (PlayerPrefs.HasKey("MaxTime"))
        {
            Timedropdown.SelectedTime = PlayerPrefs.GetInt("MaxTime");
        }
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            SendText.theName = PlayerPrefs.GetString("PlayerName");
        }
        if (PlayerPrefs.HasKey("Lives"))
        {
            Pin.livesRemaining = PlayerPrefs.GetInt("Lives");
        }
        if (PlayerPrefs.HasKey("MaxLives"))
        {
            Livesdropdown.lives = PlayerPrefs.GetInt("MaxLives");
        }
        if (PlayerPrefs.HasKey("Score"))
        {
            Score.pinCount = PlayerPrefs.GetInt("Score");
        }
    }
}
