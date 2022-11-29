using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMeteorSystem : MonoBehaviour
{
    public ParticleSystem PS;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        void KillEnemy()
        {

            PS.transform.SetParent(null);

            PS.Play();



            Destroy(PS.gameObject, 5);



            Destroy(this.gameObject);
        }
    }
}
