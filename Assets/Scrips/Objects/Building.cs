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

    [Header("----Estructuras----")]
    [SerializeField] protected GameObject Mina;
    [SerializeField] protected GameObject Granja;

    [Header("----Inventario----")]
    [SerializeField] protected float Wood = 0;
    [SerializeField] protected float Rock = 0;
    [SerializeField] protected float Metal = 0;
    [SerializeField] protected float Money = 0;
    [SerializeField] protected float Diamond = 0;
    void Start() 
    {
        Mina.SetActive(false);
        Granja.SetActive(false);
        contMejorasM = Mathf.Min(contMejorasM, 10);
        contMejorasF = Mathf.Min(contMejorasF, 10);
        textMeshProM.text = $"Wood = {WoodPriceM} \nRock = {RockPriceM} ";
        textMeshProF.text = $"Wood = {WoodPriceG}";
    }
    protected void Update()
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
        if (DetectorMaxLevelM == true)
        {
            textMeshProM.text = $"Wood = Max \nRock = Max";
        }
        if (DetectorMaxLevelF == true)
        {
            textMeshProF.text = $"Wood = Max \nRock = Max";
        }
    }
    protected virtual void IsDropping()
    {

    }
}
