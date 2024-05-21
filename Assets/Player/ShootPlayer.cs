using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform shootPoint2;
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.position = shootPoint.position;
            obj.GetComponent<Bullets>().SetDirection(shootPoint.forward);
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameObject obj = Instantiate(prefab2);
            obj.transform.position = shootPoint.position;
            obj.GetComponent<Bullets>().SetDirection(shootPoint.forward);
        }
    }
}
