using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenuScript : MonoBehaviour
{
    public Text Mode;
    public Text LapCount;
    public Text OppCount;
    private bool TimeTrial = true;
    private int CurrentLapCount = 1;
    private int CurrentOppCount = 1;
    public int TimeTrialSceneNumber;
    public int RaceTrackSceneNumber;
    public GameObject LoadScreen;
    public GameObject OpponentsOn;
    public GameObject LapsOn;

    public void ModeNext(){
        if(TimeTrial == true){
            Mode.text = "RACE";
            TimeTrial = false;
            OpponentsOn.SetActive(true);
            LapsOn.SetActive(true);
        }
    }

    public void ModeBack(){
        if(TimeTrial == false){
            Mode.text = "TIME TRIAL";
            TimeTrial = true;
            OpponentsOn.SetActive(false);
            LapsOn.SetActive(false);
        }
    }

    public void LapCountNext(){
        if(CurrentLapCount < 12){
            CurrentLapCount++;
            LapCount.text = CurrentLapCount + " - LAPS";
            UniversalSave.LapCount = CurrentLapCount;
        }
    }

    public void LapCountBack(){
        if(CurrentLapCount > 2){
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " - LAPS";
            UniversalSave.LapCount = CurrentLapCount;
        }
        else if (CurrentLapCount == 2){
            CurrentLapCount--;
            LapCount.text = CurrentLapCount + " - LAP";
            UniversalSave.LapCount = CurrentLapCount;
        }
    }

    public void OppCountNext(){
        if(CurrentOppCount < 7){
            CurrentOppCount++;
            OppCount.text = CurrentOppCount + " - OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOppCount;
        }
    }

    public void OppCountBack(){
        if(CurrentOppCount > 2){
            CurrentOppCount--;
            OppCount.text = CurrentOppCount + " - OPPONENTS";
            UniversalSave.OpponentsCount = CurrentOppCount;
        }
        else if (CurrentOppCount == 2){
            CurrentOppCount--;
            OppCount.text = CurrentOppCount + " - OPPONENT";
            UniversalSave.OpponentsCount = CurrentOppCount;
        }
    }

    public void BeginRace(){
        if(TimeTrial == true){
            StartCoroutine(WaitToLoad());           
        }
        if(TimeTrial == false){
            StartCoroutine(WaitToLoad2());    
        }
    }

    void ResetValues(){
        Time.timeScale = 1.0f;
        SaveScript.LapNumber = 0;
        SaveScript.LapChange = false;
        SaveScript.LapTimeMinutes = 0.0f;
        SaveScript.LapTimeSeconds = 0.0f;
        SaveScript.RaceTimeMinutes = 0.0f;
        SaveScript.RaceTimeSeconds = 0.0f;
        SaveScript.LastLapM = 0.0f;
        SaveScript.LastLapS = 0.0f;
        SaveScript.GameTime = 0.0f;
        SaveScript.LastCheckPoint1 = 0.0f;
        SaveScript.LastCheckPoint2 = 0.0f;
        SaveScript.ThisCheckPoint1 = 0.0f;
        SaveScript.ThisCheckPoint2 = 0.0f;
        SaveScript.CheckPointPass1 = false;
        SaveScript.CheckPointPass2 = false;
        SaveScript.HalfWayActivated = true;
        SaveScript.RaceStart = false;
        SaveScript.Raceover = false;
        SaveScript.PlayerPosition = 0;
        SaveScript.Gold = false;
        SaveScript.Silver = false;
        SaveScript.Bronze = false;
        SaveScript.Fail = false;
        SaveScript.AICar1LapNumber = 0;
        SaveScript.AICar2LapNumber = 0;
        SaveScript.AICar3LapNumber = 0;
        SaveScript.AICar4LapNumber = 0;
        SaveScript.AICar5LapNumber = 0;
        SaveScript.AICar6LapNumber = 0;
        SaveScript.AICar7LapNumber = 0;
    }

    IEnumerator WaitToLoad(){
        ResetValues();
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCount = 1;
        UniversalSave.OpponentsCount = 0;
        SceneManager.LoadScene(TimeTrialSceneNumber);
    }

    IEnumerator WaitToLoad2(){
        ResetValues();
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCount = CurrentLapCount;
        UniversalSave.OpponentsCount = CurrentOppCount;
        SceneManager.LoadScene(RaceTrackSceneNumber);
    }
}
