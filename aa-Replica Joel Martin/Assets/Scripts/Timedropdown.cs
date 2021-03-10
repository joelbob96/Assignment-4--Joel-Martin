using UnityEngine;
using UnityEngine.UI;

public class Timedropdown : MonoBehaviour
{
    public static int SelectedTime;
    public Dropdown noSelected;

    void Start()
    {
        SelectedTime = 10;
    }

    void Update()
    {
        switch (noSelected.value)
        {
            case 0:
                SelectedTime = 10;
                break;
            case 1:
                SelectedTime = 20;
                break;
            case 2:
                SelectedTime = 30;
                break;
            default:
                SelectedTime = 10;
                break;

        }
    }
}
