using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : HealthSystem
{
    [SerializeField] GameObject Drop;
    [SerializeField] Transform DropPositon;
    bool isdead = false;
    protected override void isDropping()
    {
        if (Health <= 0 && isdead == false)
        {
            GameObject obj = Instantiate(Drop);
            obj.transform.position = DropPositon.transform.position;
            isdead = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletNormal"))
        {
            Health -= Damage;
        }
        if (other.gameObject.CompareTag("BulletEspecial"))
        {
            Health -= DamageEspecial;
        }
    }
}
