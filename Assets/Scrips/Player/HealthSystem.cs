using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Damage;
    private void Update()
    {
        Health = Mathf.Max(Health, 0);
        Health = Mathf.Min(Health, 100);
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
