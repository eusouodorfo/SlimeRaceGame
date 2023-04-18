using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimeTrial : MonoBehaviour
{
    public Text TimeTrialMinutesG;
    public Text TimeTrialMinutesS;
    public Text TimeTrialMinutesB;
    public Text TimeTrialSecondsG;
    public Text TimeTrialSecondsS;
    public Text TimeTrialSecondsB;

    public Text WinMessage;

    public GameObject TimeTrialObject;
    public GameObject TimeTrialResults;
    public GameObject GoldStar;
    public GameObject SilverStar;
    public GameObject BronzeStar;

    private bool Winner = false;

    void Start()
    {
        TimeTrialObject.SetActive(true);
        TimeTrialResults.SetActive(false);
    }

    
    void Update()
    {
        //configuracao do time trial gold
        if(SaveScript.TimeTrialMinG <= 9){
            TimeTrialMinutesG.text = "0" + SaveScript.TimeTrialMinG.ToString() + ":";
        }
        if(SaveScript.TimeTrialMinG >= 10){
            TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString() + ":";
        }
         if(SaveScript.TimeTrialSecG <= 9){
            TimeTrialSecondsG.text = "0" + SaveScript.TimeTrialSecG.ToString();
        }
        if(SaveScript.TimeTrialSecG >= 10){
            TimeTrialSecondsG.text = SaveScript.TimeTrialSecG.ToString();
        }

        //configuracao do time trial silver
        if(SaveScript.TimeTrialMinS <= 9){
            TimeTrialMinutesS.text = "0" + SaveScript.TimeTrialMinS.ToString() + ":";
        }
        if(SaveScript.TimeTrialMinS >= 10){
            TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString() + ":";
        }
         if(SaveScript.TimeTrialSecS <= 9){
            TimeTrialSecondsS.text = "0" + SaveScript.TimeTrialSecS.ToString();
        }
        if(SaveScript.TimeTrialSecS >= 10){
            TimeTrialSecondsS.text = SaveScript.TimeTrialSecS.ToString();
        }

        //configuracao do time trial bronze
        if(SaveScript.TimeTrialMinB <= 9){
            TimeTrialMinutesB.text = "0" + SaveScript.TimeTrialMinB.ToString() + ":";
        }
        if(SaveScript.TimeTrialMinB >= 10){
            TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString() + ":";
        }
         if(SaveScript.TimeTrialSecB <= 9){
            TimeTrialSecondsB.text = "0" + SaveScript.TimeTrialSecB.ToString();
        }
        if(SaveScript.TimeTrialSecB >= 10){
            TimeTrialSecondsB.text = SaveScript.TimeTrialSecB.ToString();
        }

        if(SaveScript.Raceover == true){
            if(Winner == false){
                 Winner = true;
                StartCoroutine(WinDisplay());
            }
        }
    }

    IEnumerator WinDisplay(){
        yield return new WaitForSeconds(0.15f);
        TimeTrialResults.SetActive(true);
        if(SaveScript.Gold == true){
            WinMessage.text = "YOU WON GOLD TIME";
            GoldStar.SetActive(true);
        }
        if(SaveScript.Silver == true){
            WinMessage.text = "YOU WON SILVER TIME";
            SilverStar.SetActive(true);
        }
        if(SaveScript.Bronze == true){
            WinMessage.text = "YOU WON BRONZE TIME";
            BronzeStar.SetActive(true);
        }
        if(SaveScript.Fail == true){
            WinMessage.text = "TRY AGAIN!";
        }
    }

}
