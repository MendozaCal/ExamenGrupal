using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiferentShoot : LargeDistance
{
    protected override void Move()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) >= distanceAtack)
        {
            Vector3 direction = Player.position - transform.position;
            direction.Normalize();
            transform.position += direction * maxSpeed * Time.deltaTime;
            transform.LookAt(Player.position);
        }
        if (Player != null && Vector3.Distance(transform.position, Player.position) <= distanceAtack)
        {
            Vector3 direction = Player.position - transform.position;
            Vector3 separation = new Vector3(0, direction.x, -direction.z);
            separation.Normalize();
            transform.position += separation * maxSpeed * Time.deltaTime;
        }
    }
}
