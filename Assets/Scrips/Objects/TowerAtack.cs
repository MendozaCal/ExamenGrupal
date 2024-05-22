using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAtack : MonoBehaviour
{
    protected float distanceAtack = 100;
    protected Transform Enemy;
    [SerializeField] protected GameObject prefab;
    [SerializeField] protected Transform shootPoint;
    protected float cont;
    private void Awake()
    {
        Enemy = GameObject.FindWithTag("SuicideEnemy").transform;
    }
    void Update()
    {
        Aim();
    }
    protected virtual void Aim()
    {
        if (Enemy != null && Vector3.Distance(transform.position, Enemy.position) <= distanceAtack)
        {
            cont += Time.deltaTime;
            if (cont >= 2)
            {
                ShootEnemy();
                cont = 0;
            }
        }
    }
    public void ShootEnemy()
    {
        transform.LookAt(Enemy.position);
        GameObject obj = Instantiate(prefab);
        obj.transform.position = shootPoint.position;
        obj.GetComponent<Bullets>().SetDirection(shootPoint.forward);
    }
}
