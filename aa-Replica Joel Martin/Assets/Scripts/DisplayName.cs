using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public GameObject textDisplay;

    void Update()
    {
        textDisplay.GetComponent<Text>().text = "Player: " + SendText.theName;
    }

    
}
