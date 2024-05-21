using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    private Vector3 direction;
    float timeBullet = 0;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    void Update()
    {
        rb.velocity = direction * speed;
        TimeToDestroy();
    }
    void TimeToDestroy()
    {
        timeBullet += Time.deltaTime;
        if (timeBullet >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
