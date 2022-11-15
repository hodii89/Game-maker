using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MeteorFlight : MonoBehaviour
{
    public BoxCollider2D collider;

    public Rigidbody2D rb;


    private float width;

    private float FlightSpeed = -20f;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(FlightSpeed, 0);
    }
    void Update()
    {

    }
}
