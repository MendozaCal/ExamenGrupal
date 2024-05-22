using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideEnemy : ShortDistance
{
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
