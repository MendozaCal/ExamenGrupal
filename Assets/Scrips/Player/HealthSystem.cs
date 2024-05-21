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
    }
    protected virtual void isDropping() 
    {

    }
}
