using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventary : Building
{
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
        if (collision.gameObject.CompareTag("Money"))
        {
            Money++;
        }
        if (collision.gameObject.CompareTag("Diamond"))
        {
            Diamond++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ButtonMina") && Rock >= RockPriceM && Wood >= WoodPriceM && DetectorMaxLevelM == false)
        {
            BuyMina();
            LevelUpMina();
        }
        if (other.gameObject.CompareTag("ButtonGranja") && Wood >= WoodPriceG && DetectorMaxLevelF == false)
        {
            BuyFarm();
            LevelUpFarm();
        }
        if (other.gameObject.CompareTag("ButtonTorre") && Diamond >= DiamiondPriceT && Metal >= MetalPriceT && Money >= MoneyPriceT && DetectorMaxLevelT == false)
        {
            BuyTower();
            LevelUpTower();
            
        }
        if (other.gameObject.CompareTag("ButtonMeatStore") && Meat >= 10)
        {
            Meat -= 10;
            Money += 5;
        }
        if (other.gameObject.CompareTag("ButtonFlowerStore") && Flower >= 10)
        {
            Flower -= 10;
            Money += 5;
        }

    }
    protected override void IsDropping()
    {
        if (MinaIsTrue == true)
        {
            TimerM += Time.deltaTime;
            if (TimerM >= TimeToSpawnM)
            {
                GameObject obj = Instantiate(MaterialDropM);
                obj.transform.position = DropPositionM.transform.position;
                TimerM = 0;
            }
        }
        if (FarmIsTrue == true)
        {
            TimerF += Time.deltaTime;
            if (TimerF >= TimeToSpawnF)
            {
                GameObject obj = Instantiate(MaterialDropF[0]);
                GameObject obj1 = Instantiate(MaterialDropF[1]);
                obj.transform.position = DropPositionFMeat.transform.position;
                obj1.transform.position = DropPositionFlower.transform.position;
                TimerF = 0;
            }
        }
    }
    void BuyMina()
    {
        Rock -= RockPriceM;
        Wood -= WoodPriceM;
        Mina.SetActive(true);
    }
    void BuyFarm()
    {
        Wood -= WoodPriceG;
        Granja.SetActive(true);
    }
    void BuyTower()
    {
        Diamond -= DiamiondPriceT;
        Money -= MoneyPriceT;
        Metal -= MetalPriceT;
    }
    void LevelUpMina()
    {
        WoodPriceM *= 1.25f;
        RockPriceM *= 1.25f;
        contMejorasM++;
        MinaIsTrue = true;
        TimeToSpawnM -= 2;
        if (contMejorasM >= 10)
        {
            DetectorMaxLevelM = true;
        }
    }
    void LevelUpFarm()
    {
        WoodPriceG *= 1.25f;
        contMejorasF++;
        FarmIsTrue = true;
        TimeToSpawnF -= 1;
        if (contMejorasF >= 10)
        {
            DetectorMaxLevelF = true;
        }
    }
    void LevelUpTower()
    {
        DiamiondPriceT *= 5;
        MetalPriceT *= 5f;
        MoneyPriceT *= 5f;
        contMejorasT++;
        Torre1.SetActive(true);
        if (contMejorasT >= 2)
        {
            Torre2.SetActive(true);
            if (contMejorasT >= 3)
            {
                Torre3.SetActive(true);
                DetectorMaxLevelT = true;
            }
        }
    }
}
