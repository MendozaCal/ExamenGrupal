using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEstructure : HealthSystem
{
    [SerializeField] GameObject[] MaterialDrop;
    [SerializeField] float Timer = 0;
    [SerializeField] float TimeToSpawn = 30;
    [SerializeField] Transform DropPosition;
    [SerializeField] bool Diamond = false;
    [SerializeField] bool Meat = false;
    [SerializeField] bool Plants = false;
    int cont;
    Inventary inventary;
    private void Start()
    {
        inventary = GetComponent<Inventary>();
        //cont = inventary.contMejorasM;
    }
    protected override void isDropping()
    {
        Timer += Time.deltaTime;
        if (Timer >= TimeToSpawn && Diamond == true)
        {
            GameObject obj = Instantiate(MaterialDrop[0]);
            obj.transform.position = DropPosition.transform.position;
            Timer = 0;
            
        }
    }


}
