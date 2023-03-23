using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    public Text SpeedText;
    public Text GearText;
    public Text LapNumberText;
    public Text TotalLapsText;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText; 
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText; 
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;
    public Text CheckPointTime;
    public GameObject CheckPointDisplay;
    private float DisplaySpeed;
    public int TotalLaps = 3;
 

    void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GearText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = "/" + TotalLaps.ToString();
        CheckPointDisplay.SetActive(false);
    }

   
    void Update()
    {
        //velocimetro
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString());
        GearText.text = (SaveScript.Gear + 1).ToString();

        //Numero de volta
        LapNumberText.text = SaveScript.LapNumber.ToString();

        //Tempo de volta
        if (SaveScript.LapTimeMinutes <= 9){
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        } 
        else if(SaveScript.LapTimeMinutes >= 10){
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        if (SaveScript.LapTimeSeconds <= 9){
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        } 
        else if(SaveScript.LapTimeSeconds >= 10){
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }


         //Tempo de corrida
        if (SaveScript.RaceTimeMinutes <= 9){
            RaceTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        } 
        else if(SaveScript.RaceTimeMinutes >= 10){
            RaceTimeMinutesText.text = (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + ":";
        }
        if (SaveScript.RaceTimeSeconds <= 9){
            RaceTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        } 
        else if(SaveScript.RaceTimeSeconds >= 10){
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        //volta rapida
        if(SaveScript.LastLapM == SaveScript.BestLapTimeM){
            if(SaveScript.LastLapS < SaveScript.BestLapTimeS){
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
            }
        }

         if(SaveScript.LastLapM < SaveScript.BestLapTimeM){
            SaveScript.BestLapTimeM = SaveScript.LastLapM;
            SaveScript.BestLapTimeS = SaveScript.LastLapS;           
        }

        //exibindo melhor volta rapida
        if (SaveScript.BestLapTimeM <= 9){
            BestLapTimeMinutes.text = "0" + (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        } 
        else if(SaveScript.BestLapTimeM >= 10){
            BestLapTimeMinutes.text = (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + ":";
        }
        if (SaveScript.BestLapTimeS <= 9){
            BestLapTimeSeconds.text = "0" + (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        } 
        else if(SaveScript.BestLapTimeS >= 10){
            BestLapTimeSeconds.text = (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }


        //Checkpoint 1
        if(SaveScript.CheckPointPass1 == true){
            
            SaveScript.CheckPointPass1 = false;
            CheckPointDisplay.SetActive(true);

            //parcial negativa
            if(SaveScript.ThisCheckPoint1 > SaveScript.LastCheckPoint1){
                CheckPointTime.color = Color.red;
                CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint1 - SaveScript.LastCheckPoint1).ToString();
                StartCoroutine(CheckPointOff());
            }

            //parcial positiva
            if(SaveScript.ThisCheckPoint1 < SaveScript.LastCheckPoint1){
                CheckPointTime.color = Color.green;
                CheckPointTime.text = "+" + (SaveScript.LastCheckPoint1 - SaveScript.ThisCheckPoint1).ToString();
                StartCoroutine(CheckPointOff());
            }
        }

        //Checkpoint 2
        if(SaveScript.CheckPointPass2 == true){
            
            SaveScript.CheckPointPass2 = false;
            CheckPointDisplay.SetActive(true);

            //parcial negativa
            if(SaveScript.ThisCheckPoint2 > SaveScript.LastCheckPoint2){
                CheckPointTime.color = Color.red;
                CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint2 - SaveScript.LastCheckPoint2).ToString();
                StartCoroutine(CheckPointOff());
            }

            //parcial positiva
            if(SaveScript.ThisCheckPoint2 < SaveScript.LastCheckPoint2){
                CheckPointTime.color = Color.green;
                CheckPointTime.text = "+" + (SaveScript.LastCheckPoint2 - SaveScript.ThisCheckPoint2).ToString();
                StartCoroutine(CheckPointOff());
            }
        }

        //Checkpoint 3
        if(SaveScript.CheckPointPass3 == true){
            
            SaveScript.CheckPointPass3 = false;
            CheckPointDisplay.SetActive(true);

            //parcial negativa
            if(SaveScript.ThisCheckPoint3 > SaveScript.LastCheckPoint3){
                CheckPointTime.color = Color.red;
                CheckPointTime.text = "-" + (SaveScript.ThisCheckPoint3 - SaveScript.LastCheckPoint3).ToString();
                StartCoroutine(CheckPointOff());
            }

            //parcial positiva
            if(SaveScript.ThisCheckPoint3 < SaveScript.LastCheckPoint3){
                CheckPointTime.color = Color.green;
                CheckPointTime.text = "+" + (SaveScript.LastCheckPoint3 - SaveScript.ThisCheckPoint3).ToString();
                StartCoroutine(CheckPointOff());
            }
        }
    }

    IEnumerator CheckPointOff(){
        yield return new WaitForSeconds(2);
        CheckPointDisplay.SetActive(false);
    }
}
