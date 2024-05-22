using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Building : MonoBehaviour
{
    [Header("----Precio Mina----")]
    [SerializeField] protected float TimerM = 0;
    [SerializeField] protected float TimeToSpawnM = 40;
    [SerializeField] protected float WoodPriceM = 10;
    [SerializeField] protected float RockPriceM = 5;
    [SerializeField] protected GameObject MaterialDropM;
    [SerializeField] protected Transform DropPositionM;
    [SerializeField] protected TextMeshPro textMeshProM;
    public int contMejorasM = 0;
    protected bool DetectorMaxLevelM;
    protected bool MinaIsTrue = false;

    [Header("----Precio Granja----")]
    [SerializeField] protected float TimerF = 0;
    [SerializeField] protected float TimeToSpawnF = 20;
    [SerializeField] protected float WoodPriceG = 20;
    [SerializeField] protected GameObject[] MaterialDropF;
    [SerializeField] protected Transform DropPositionFMeat;
    [SerializeField] protected Transform DropPositionFlower;
    [SerializeField] protected TextMeshPro textMeshProF;
    public int contMejorasF = 0;
    protected bool DetectorMaxLevelF;
    protected bool FarmIsTrue = false;

    [Header("----Precio Torre----")]
    [SerializeField] protected float TimerT = 0;
    [SerializeField] protected float TimeToSpawnT = 40;
    [SerializeField] protected float DiamiondPriceT = 10;
    [SerializeField] protected float MetalPriceT = 5;
    [SerializeField] protected float MoneyPriceT = 5;
    [SerializeField] protected TextMeshPro textMeshProT;
    public int contMejorasT = 0;
    protected bool DetectorMaxLevelT;
    protected bool TorreIsTrue = false;

    [Header("----Venta----")]
    [SerializeField] protected TextMeshPro textMeatPrice;
    [SerializeField] protected TextMeshPro textFlowerPrice;

    [Header("----Estructuras----")]
    [SerializeField] protected GameObject Mina;
    [SerializeField] protected GameObject Granja;
    [SerializeField] protected GameObject Torre1;
    [SerializeField] protected GameObject Torre2;
    [SerializeField] protected GameObject Torre3;

    [Header("----Inventario----")]
    [SerializeField] protected float Wood = 0;
    [SerializeField] protected float Rock = 0;
    [SerializeField] protected float Metal = 0;
    [SerializeField] protected float Diamond = 0;
    [SerializeField] protected float Money = 0;
    [SerializeField] protected float Meat = 0;
    [SerializeField] protected float Flower = 0;
    void Start() 
    {
        Torre1.SetActive(false);
        Torre2.SetActive(false);
        Torre3.SetActive(false);
        Mina.SetActive(false);
        Granja.SetActive(false);
        contMejorasM = Mathf.Min(contMejorasM, 10);
        contMejorasF = Mathf.Min(contMejorasF, 10);
        textMeshProM.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
        textMeshProT.text = $"Diamond = {DiamiondPriceT} \nMetal = {MetalPriceT}\nMoney = {MoneyPriceT} ";
        textMeshProF.text = $"Wood = {WoodPriceG}";
        textMeatPrice.text = $"10 x Meat =\n5 Coins";
        textFlowerPrice.text = $"10 x Flower =\n5 Coins";
    }
    protected void FixedUpdate()
    {
        textManager();
        IsDropping();
    }
    void textManager()
    {
        WoodPriceM = Mathf.Round(WoodPriceM);
        RockPriceM = Mathf.Round(RockPriceM);
        WoodPriceG = Mathf.Round(WoodPriceG);
        textMeshProM.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
        textMeshProF.text = $"Wood = {WoodPriceG}";
        textMeshProT.text = $"Diamond = {DiamiondPriceT} \nMetal = {MetalPriceT}\nMoney = {MoneyPriceT} ";
        if (DetectorMaxLevelM == true)
        {
            textMeshProM.text = $"Wood = Max \nRock = Max";
        }
        if (DetectorMaxLevelF == true)
        {
            textMeshProF.text = $"Wood = Max \nRock = Max";
        }
        if (DetectorMaxLevelT == true)
        {
            textMeshProT.text = $"Diamond = Max \nMetal = Max\nMoney = Max";
        }
    }
    protected virtual void IsDropping()
    {

    }
}
