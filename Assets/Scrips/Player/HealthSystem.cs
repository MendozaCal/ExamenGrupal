using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Damage;
    [SerializeField] protected int DamageEspecial;
    protected virtual void FixedUpdate()
    {
        Health = Mathf.Max(Health, 0);
        Health = Mathf.Min(Health, 1000);
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
        isDropping();
    }
    protected virtual void isDropping() 
    {

    }
}