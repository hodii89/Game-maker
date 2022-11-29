using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour
{
    
    public float theCountdown = 0f;
    public float waitingForNextSpawn = 3f;
    public GameObject Shot;
    public Rigidbody2D rb;
    public float moveSpeed = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
     public void Update()
    {
        theCountdown -= Time.deltaTime;
        float moveDirection = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, moveDirection * moveSpeed);



        if (theCountdown >= 0)
        {

        }
        else if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(Shot, transform.position, Quaternion.identity);
            theCountdown = waitingForNextSpawn;

        }
        
        

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        SceneManager.LoadScene("GameOverScreen");
        }
    }
}
