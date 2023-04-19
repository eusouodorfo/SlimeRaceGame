using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCount;
    public static int OpponentsCount;
    public static int CreditAmount;
    public static bool Saving = false;
    public static bool Calculation = false;
    public static string PlayerName = "PLAYER";
    public static int RaceWon = 0;
    public static int RaceLost = 0;

    public static bool SportsCar1Owned = false;
    public static bool SportsCar2Owned = false;
    
    void Start(){
        DontDestroyOnLoad(this);
        LoadStats();
    }

    private void Update(){
        if(Saving == true){
            Saving = false;
            SaveStats();
        }
    }

    public void SaveStats(){
        PlayerPrefs.SetInt("MyCredits", CreditAmount);
        PlayerPrefs.SetString("PlayerName", PlayerName);
        PlayerPrefs.SetInt("WonRaces", RaceWon);
        PlayerPrefs.SetInt("LostRaces", RaceLost);
    }

    public void LoadStats(){
        CreditAmount = PlayerPrefs.GetInt("MyCredits");
        PlayerName = PlayerPrefs.GetString("PlayerName");
        RaceWon = PlayerPrefs.GetInt("WonRaces");
        RaceLost = PlayerPrefs.GetInt("LostRaces");
    }
}
