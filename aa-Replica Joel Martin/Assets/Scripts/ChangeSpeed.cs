using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    void Start()
    {
            Pin.speed = 20f;
            Rotator.Speed = 100f;
    }

    public void setSpeed(float newSpeed)
    {
       Pin.speed = newSpeed;
    }

    public void setRotatorSpeed(float newSpeed)
    {
        Rotator.Speed = newSpeed;
    }

    public void saveSpeed()
    {
        PlayerPrefs.SetFloat("PreferedSpeed", Pin.speed);
        PlayerPrefs.Save();
    }
}
