using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public static float Speed;
    public float currSpeed;

    void Start()
    {
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }

    void Update()
    {
        if (Mathf.FloorToInt(Timer.timeRemaining) % 2 == 1)
        {
            currSpeed = Speed * 2;
        }
        else
        {
            currSpeed = Speed;
        }
        transform.Rotate(0, 0, currSpeed * Time.deltaTime);
    }
}
