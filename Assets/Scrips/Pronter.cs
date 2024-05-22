using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pronter : MonoBehaviour
{
    [SerializeField] GameObject textMeshProUGUI1;
    [SerializeField] GameObject textMeshProUGUI2;
    [SerializeField] GameObject textMeshProUGUI3;
    void Start()
    {
        StartCoroutine(controllerCreditos());
    }
    IEnumerator controllerCreditos()
    {
        yield return new WaitForSeconds(1);
        textMeshProUGUI1.SetActive(true);
        yield return new WaitForSeconds(3);
        textMeshProUGUI1.SetActive(false);
        yield return new WaitForSeconds(1);
        textMeshProUGUI2.SetActive(true);
        yield return new WaitForSeconds(3);
        textMeshProUGUI2.SetActive(false);
        yield return new WaitForSeconds(1);
        textMeshProUGUI3.SetActive(true);
    }
}
