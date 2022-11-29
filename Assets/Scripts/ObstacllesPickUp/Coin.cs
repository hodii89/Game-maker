using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    ParticleSystem psc;
    public Sprite CreditOff;
    public float theCountdown = 3600f;
    public BoxCollider2D collider;
    public Rigidbody2D rb;


    private float width;

    public float FlightSpeed = -15f;


    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = true;

        rb.velocity = new Vector2(FlightSpeed, 0);
        psc = GetComponent<ParticleSystem>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            psc.Play();
            GameManager.instance.AddPoint();
            GetComponent<SpriteRenderer>().sprite = CreditOff;
        }


        if (other.gameObject.CompareTag("WallOfFlesh"))
        
            {
                Destroy(gameObject);
            }

    }


}
