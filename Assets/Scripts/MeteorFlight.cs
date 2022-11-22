using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MeteorFlight : MonoBehaviour
{
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
    }
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("WallOfFlesh"))
        {
            Destroy(gameObject);
        }
    }
}
