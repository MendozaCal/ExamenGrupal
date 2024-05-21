using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    public float timer = 0;
    int index = 0;
    GameObject currentObject;
    void Start()
    {
        CreateSeed();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 60)
        {
            StartCoroutine(RenovationTerrain());
            timer = 0;
        }
    }
    void CreateSeed()
    {
        if(objects != null && objects.Length > 0)
        {
            index = Random.Range(0, objects.Length);
            currentObject = Instantiate(objects[index]);
        }
    }
    IEnumerator RenovationTerrain()
    {
        Destroy(currentObject);
        yield return new WaitForSeconds(0.001f);
        currentObject = Instantiate(objects[index]);
    }
}