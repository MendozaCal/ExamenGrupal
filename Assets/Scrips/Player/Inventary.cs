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
    [SerializeField] protected float MetalPriceM = 0;
    [SerializeField] protected float MoneyPriceM = 0;
    [SerializeField] protected float DiamondPriceM = 0;
    [SerializeField] protected TextMeshPro textMeshPro;
    int contMejorasM = 0;

    [Header("----Precio Granja----")]
    [SerializeField] protected float WoodPriceG = 20;
    [SerializeField] protected float RockPriceG = 0;
    [SerializeField] protected float MetalPriceG = 0;
    [SerializeField] protected float MoneyPriceG = 0;
    [SerializeField] protected float DiamondPriceG = 0;
    int contMejorasG = 0;

    [Header("----Estructuras----")]
    [SerializeField] GameObject Mina;
    [SerializeField] GameObject Granja;
    void Start()
    {
        Mina.SetActive(false);
        Granja.SetActive(false);
        textMeshPro.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
    }
    private void Update()
    {
        textMeshPro.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
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
        if (other.gameObject.CompareTag("ButtonMina") && Rock >= RockPriceM && Wood >= WoodPriceM)
        {
            Rock -= RockPriceM;
            Wood -= WoodPriceM;
            Mina.SetActive(true);
            RockPriceM *= 1.25f;
            WoodPriceM *= 1.25f;
            contMejorasM++;
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
