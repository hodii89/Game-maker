using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTimer : MonoBehaviour
    
{
    
    public float RangeT2;
    public float theCountdown = 0f;
    public float waitingForNextSpawn = 3f;
    public Sprite T1;
    public Sprite T2;
    public Sprite T3;
    public Sprite T4;
    public Sprite T5;
    public Sprite T6;
    public Sprite T7;

    
    // Update is called once per frame
    public void Update()
    {
        theCountdown -= Time.deltaTime;


        if (theCountdown >= 0)
        {

        }
        else if (Input.GetButtonDown("Fire1"))
        {
            theCountdown = waitingForNextSpawn;
        }

        if(theCountdown <= 3f && theCountdown >= 2.5f)
        {
            GetComponent<SpriteRenderer>().sprite = T1;
        }
         if (theCountdown <= 2.5f && theCountdown >= 2f)
        {
            GetComponent<SpriteRenderer>().sprite = T2;
        }
         if (theCountdown <= 2f && theCountdown >= 1.5f)
        {
            GetComponent<SpriteRenderer>().sprite = T3;
        }
         if (theCountdown <= 1.5f && theCountdown >= 1)
        {
            GetComponent<SpriteRenderer>().sprite = T4;
        }
        if (theCountdown <= 1f && theCountdown >= 0.5f)
        {
            GetComponent<SpriteRenderer>().sprite = T5;
        }
         if (theCountdown <= 0.5f && theCountdown > 0f) 
        {
            GetComponent<SpriteRenderer>().sprite = T6;
        }
         if (theCountdown <= 0f)
        {
            GetComponent<SpriteRenderer>().sprite = T7;

        }
    }
}
