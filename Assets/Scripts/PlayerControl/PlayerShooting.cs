using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public int speed = 5;
    public int damage;
   // public CameraShake cameraShake;

    // Start is called before the first frame update
   void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0, -1);
      
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player")
        {
           // StartCoroutine(cameraShake.Shake(.15f, .4f));
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}

