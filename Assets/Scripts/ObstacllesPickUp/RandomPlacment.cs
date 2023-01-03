using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlacment : MonoBehaviour
{
   
    public GameObject[] theGoodies;

  
    [Space(3)]
    public float waitingForNextSpawn = 10;
    public float theCountdown = 10;

  
    [Header("X Spawn Range")]
    public float xMinin;
     public float xMax;
 
  
     [Header("Y Spawn Range")]
    public float yMinin;
     public float yMax;
 
 

    public void Update()
    {
        
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnGoodies();
            theCountdown = waitingForNextSpawn;
        }

        
    }
    

    void SpawnGoodies()
    {
      
        Vector2 pos = new Vector2(Random.Range(xMinin, xMax), Random.Range(yMinin, yMax));

   

        GameObject goodsPrefab = theGoodies[Random.Range(0, theGoodies.Length)];

        if
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, Random.Range(0, 360));
        }

        Instantiate(goodsPrefab, pos, transform.rotation);

        
    }
}
    

