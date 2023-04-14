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

    IEnumerator WaitToLoad(){
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCount = 1;
        UniversalSave.OpponentsCount = 0;
        SceneManager.LoadScene(TimeTrialSceneNumber);
    }

    IEnumerator WaitToLoad2(){
        yield return new WaitForSeconds(0.3f);
        LoadScreen.SetActive(true);
        UniversalSave.LapCount = CurrentLapCount;
        UniversalSave.OpponentsCount = CurrentOppCount;
        SceneManager.LoadScene(RaceTrackSceneNumber);
    }
}
