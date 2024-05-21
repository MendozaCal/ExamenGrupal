using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject Estructura;
    float Timer = 0;
    void Start()
    {
        Estructura.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        Timer += Time.deltaTime;
        if (Timer >= 10)
        {
            Estructura.SetActive(true);
        }
    }
}
