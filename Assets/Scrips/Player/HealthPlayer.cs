using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : HealthSystem
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SuicideEnemy"))
        {
            Health -= 50;
        }
        if (collision.gameObject.CompareTag("MeleeEnemy"))
        {
            Health -= 10;
        }
    } 
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletEnemy"))
        {
            Health -= 10;
        }
        
    }
}
