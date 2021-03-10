using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    public void SaveP()
    {
        PlayerPrefs.SetFloat("PinSpeed", Pin.speed);
        PlayerPrefs.SetFloat("RotatorSpeed", Rotator.Speed);
        PlayerPrefs.SetFloat("TimeRemaining", Timer.timeRemaining);
        PlayerPrefs.SetInt("MaxTime", Timedropdown.SelectedTime); 
        PlayerPrefs.SetString("PlayerName", SendText.theName);
        PlayerPrefs.SetInt("Lives", Pin.livesRemaining);
        PlayerPrefs.SetInt("MaxLives", Livesdropdown.lives);
        PlayerPrefs.SetInt("Score", Score.pinCount);

        PlayerPrefs.Save();
    }
}
