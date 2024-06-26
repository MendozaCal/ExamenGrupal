using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform shootPoint2;
    float Delay = 0;
    float Delay1 = 0;

    void Update()
    {
        Delay += Time.deltaTime;
        Delay1 += Time.deltaTime;
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetMouseButton(0) && Delay1>= 0.25f)
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.position = shootPoint.position;
            obj.GetComponent<Bullets>().SetDirection(shootPoint.forward);
            Delay1 = 0;
        }
        if (Input.GetMouseButtonDown(1) && Delay >= 5)
        {
            GameObject obj = Instantiate(prefab2);
            obj.transform.position = shootPoint2.position;
            obj.GetComponent<Bullets>().SetDirection(shootPoint2.forward);
            Delay = 0;
        }
    }
}
