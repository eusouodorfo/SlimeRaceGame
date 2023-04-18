using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceType : MonoBehaviour
{
    public bool TimeTrial = true;
    public float GoldMinutes;
    public float GoldSeconds;
    public float SilverMinutes;
    public float SilverSeconds;
    public float BronzeMinutes;
    public float BronzeSeconds;

    void Start()
    {
        if(TimeTrial == true){
            SaveScript.TimeTrialMinG = GoldMinutes;
            SaveScript.TimeTrialSecG = GoldSeconds;
            SaveScript.TimeTrialMinS = SilverMinutes;
            SaveScript.TimeTrialSecS = SilverSeconds;
            SaveScript.TimeTrialMinB = BronzeMinutes;
            SaveScript.TimeTrialSecB = BronzeSeconds;
        }
    }

    void Update()
    {
        if(SaveScript.Raceover == true){
            if(TimeTrial == true){

                //definir tempo gold
                if(SaveScript.RaceTimeMinutes < GoldMinutes){
                    Debug.Log("Gold");
                    SaveScript.Gold = true;
                }
                if(SaveScript.RaceTimeMinutes == GoldMinutes && SaveScript.RaceTimeSeconds < GoldSeconds){
                    Debug.Log("Gold");
                    SaveScript.Gold = true;
                }

                //definir tempo silver
                if(SaveScript.RaceTimeMinutes < SilverMinutes){
                    if(SaveScript.Gold == false){
                        Debug.Log("Silver");
                        SaveScript.Silver = true;
                    }
                }
                if(SaveScript.RaceTimeMinutes == SilverMinutes && SaveScript.RaceTimeSeconds < SilverSeconds){
                    Debug.Log("Silver");
                    SaveScript.Silver = true;
                }

                //definir tempo bronze
                if(SaveScript.RaceTimeMinutes < BronzeMinutes){
                    if(SaveScript.Gold == false && SaveScript.Silver == false){
                        Debug.Log("Bronze");
                        SaveScript.Bronze = true;
                    }
                }
                if(SaveScript.RaceTimeMinutes == BronzeMinutes && SaveScript.RaceTimeSeconds < BronzeSeconds){
                    Debug.Log("Bronze");
                    SaveScript.Bronze = true;
                }

                else if(SaveScript.Gold == false && SaveScript.Silver == false && SaveScript.Bronze == false){
                    Debug.Log("Fail");
                    SaveScript.Fail = true;
                }

            }
        }
    }
}
