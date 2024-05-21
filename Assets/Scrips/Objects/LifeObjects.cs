using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeObjects : HealthSystem
{
    [SerializeField] GameObject[] MaterialDrop;
    [SerializeField] Transform DropPositon;
    [SerializeField] bool Wood = false;
    [SerializeField] bool Rock = false;
    [SerializeField] bool Metal = false;
    protected override void Update()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
        isDropping();
    }
    protected override void isDropping()
    {
        if (Health <= 0 && Wood == true)
        {
            GameObject obj = Instantiate(MaterialDrop[0]);
            obj.transform.position = DropPositon.transform.position;
            Wood = false;
        }
        if (Health <= 0 && Rock == true)
        {
            GameObject obj = Instantiate(MaterialDrop[1]);
            obj.transform.position = DropPositon.transform.position;
            Rock = false;
        }
        if (Health <= 0 && Metal == true)
        {
            GameObject obj = Instantiate(MaterialDrop[2]);
            obj.transform.position = DropPositon.transform.position;
            Metal = false;
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
