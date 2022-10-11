using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D collider;

    public Rigidbody2D rb;

    public bool Death = false;


    private float width;

    private float scrollSpeed = -4f;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);

    }

    // Update is called once per frame
    void Update()
    {
       
         if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 1.99f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();

        }
        
        void ResetObstacle()
        {
            transform.GetChild(0).localPosition = new Vector3(0, Random.Range(-4, 5), 0);
        }
        
       
    }
}

  