using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeObjects : HealthSystem
{
    [SerializeField] GameObject[] MaterialDrop;
    [SerializeField] bool Wood = false;
    [SerializeField] bool Rock = false;
    [SerializeField] bool Metal = false;
    float cont = 0;
    private void Update()
    {
        isDropping();
    }
    void isDropping()
    {
        if (Health <= 0 && Wood == true)
        {
            GameObject obj = Instantiate(MaterialDrop[0]);
            Wood = false;
        }
        if (Health <= 0 && Rock == true)
        {
            GameObject obj = Instantiate(MaterialDrop[1]);
        }
        if (Health <= 0 && Metal == true)
        {
            GameObject obj = Instantiate(MaterialDrop[2]);
        }
    }
}
