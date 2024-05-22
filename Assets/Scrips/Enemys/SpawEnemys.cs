using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemys : MonoBehaviour
{
    public GameObject[] Enemys;
    public Transform spawnPoint;
    public float spawnDelay = 2;
    public float OleadasDuration = 0;
    public float OleadasMax = 20;
    public float OleadasDelay = 0;
    public float time = 0;
    Transform Player;
    private void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        OleadasDuration += Time.deltaTime;
        time += Time.deltaTime;
        if (Player != null && time >= spawnDelay && OleadasDuration <= OleadasMax)
        {
            spawnEnemy();
            time = 0;
            
        }
        if (OleadasDuration >= OleadasMax)
        {
            OleadasDelay += Time.deltaTime;
            if (OleadasDelay >= 10)
            {
                OleadasDuration = 0;
                OleadasMax += 10;
                OleadasDelay = 0;
            }
        }
    }
    void spawnEnemy()
    {
        int randomIndex = Random.Range(0, Enemys.Length);
        GameObject enemyToSpawn = Enemys[randomIndex];
        enemyToSpawn.transform.position = spawnPoint.position;
        Instantiate(enemyToSpawn);
    }
}
