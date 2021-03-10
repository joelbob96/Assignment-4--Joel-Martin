using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    private bool isHit = false;

    public static float speed;
    public static int livesRemaining;
    public Rigidbody2D rb;

    void Update()
    {
        if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);

        if(livesRemaining < 1)
        {
            FindObjectOfType<MyGameManager>().EndGame();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.pinCount++;
            isPinned = true;
        }else if(col.tag == "Pin" && isHit == false) //&& livesRemaining > 0)
        {
            isHit = true;
            livesRemaining = livesRemaining - 1;
        }
        
    }
}
