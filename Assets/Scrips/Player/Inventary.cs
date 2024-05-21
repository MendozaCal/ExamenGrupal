using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventary : MonoBehaviour
{
    [Header("----Inventario----")]
    [SerializeField] protected float Wood = 0;
    [SerializeField] protected float Rock = 0;
    [SerializeField] protected float Metal = 0;
    [SerializeField] protected float Money = 0;
    [SerializeField] protected float Diamond = 0;

    [Header("----Precio Mina----")]
    [SerializeField] protected float WoodPriceM = 10;
    [SerializeField] protected float RockPriceM = 5;

    [SerializeField] protected TextMeshPro textMeshProM;
    public int contMejorasM = 0;
    bool DetectorMaxLevelM;

    [Header("----Precio Granja----")]
    [SerializeField] protected float WoodPriceG = 20;
    [SerializeField] protected TextMeshPro textMeshProG;
    public int contMejorasG = 0;
    bool DetectorMaxLevelG;

    [Header("----Estructuras----")]
    [SerializeField] GameObject Mina;
    [SerializeField] GameObject Granja;
    void Start()
    {
        Mina.SetActive(false);
        Granja.SetActive(false);
        contMejorasM = Mathf.Min(contMejorasM,10);
        contMejorasG = Mathf.Min(contMejorasG, 10);
        textMeshProM.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
        textMeshProG.text = $"Wood = {WoodPriceG}";
    }
    private void Update()
    {
        WoodPriceM = Mathf.Round(WoodPriceM);
        RockPriceM = Mathf.Round(RockPriceM);
        WoodPriceG = Mathf.Round(WoodPriceG);
        textMeshProM.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
        if (DetectorMaxLevelM == true)
        {
            textMeshProM.text = $"Wood = Max \nRock = Max";
        }
        textMeshProG.text = $"Wood = {WoodPriceG}";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wood"))
        {
            Wood++;
        }
        if (collision.gameObject.CompareTag("Rock"))
        {
            Rock++;
        }
        if (collision.gameObject.CompareTag("Metal"))
        {
            Metal++;
        }
        /*if (collision.gameObject.CompareTag("Money"))
        {
            Money++;
        }
        if (collision.gameObject.CompareTag("Diamond"))
        {
            Diamond++;
        }*/
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ButtonMina") && Rock >= RockPriceM && Wood >= WoodPriceM && DetectorMaxLevelM == false)
        {
            Rock -= RockPriceM;
            Wood -= WoodPriceM;
            Mina.SetActive(true);
            WoodPriceM *= 1.25f;
            RockPriceM *= 1.25f;
            contMejorasM++;
            if (contMejorasM >= 10)
            {
                DetectorMaxLevelM = true;
            }
        }
        if (other.gameObject.CompareTag("ButtonGranja") &&  Wood >= WoodPriceG)
        {
            Wood -= WoodPriceG;
            Granja.SetActive(true);
            WoodPriceG *= 1.25f;
            contMejorasG++;
        }

    }
}
