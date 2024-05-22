using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Damage;
    [SerializeField] protected int DamageEspecial;
     protected virtual void Update()
    {
        Health = Mathf.Max(Health, 0);
        Health = Mathf.Min(Health, 100);
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
        isDropping();
    }
    protected virtual void isDropping() 
    {

    }
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
}
