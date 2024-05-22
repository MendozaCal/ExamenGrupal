using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideEnemy : MoveController
{
    protected override void Move()
    {
        if (Player != null && Vector3.Distance(transform.position, Player.position) >= 0)
        {
            Vector3 direction = Player.position - transform.position;
            direction.Normalize();
            transform.position += direction * maxSpeed * Time.deltaTime;
            transform.LookAt(Player.position);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
