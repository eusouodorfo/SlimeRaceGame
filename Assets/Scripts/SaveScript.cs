using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class SaveScript : MonoBehaviour
{
    //variaveis sobre o carro
    public static float Speed;
    public static float TopSpeed;
    public static bool BrakeSlide;
    public static int Gear;
    public static bool OnTheRoad = true;
    public static bool OnTheTerrain = false;
    public static bool Rumble1 = false;
    public static bool Rumble2 = false;
    public static bool WrongWay = false;

    //referentes a corrida
    public static int PlayerPosition;
    public static float LastCheckPoint1;
    public static float ThisCheckPoint1;
    public static float LastCheckPoint2;
    public static float ThisCheckPoint2;
    public static float LastCheckPoint3;
    public static float ThisCheckPoint3;
    public static bool CheckPointPass1 = false;
    public static bool CheckPointPass2 = false;
    public static bool CheckPointPass3 = false;
    public static int FinishPositionID = 0;
    public static bool HalfWayActivated = true;
    public static bool WWTextReset = false;
    public static bool RaceStart = false;
    public static int MaxLaps;
    public static bool Raceover = false;
    
    //variaveis em relacao a tempo
    public static bool NewRecord = false;
    public static int LapNumber;
    public static bool LapChange = false;
    public static float LapTimeMinutes;
    public static float LapTimeSeconds;
    public static float RaceTimeMinutes;
    public static float RaceTimeSeconds;
    public static float BestLapTimeM;
    public static float BestLapTimeS;
    public static float LastLapM;
    public static float LastLapS;
    public static float GameTime;

    //ia
    public static int AICar1LapNumber = 0;
    public static int AICar2LapNumber = 0;
    public static int AICar3LapNumber = 0;
    public static int AICar4LapNumber = 0;
    public static int AICar5LapNumber = 0;
    public static int AICar6LapNumber = 0;
    public static int AICar7LapNumber = 0;
   
    //time trial
    public static float TimeTrialMinG;
    public static float TimeTrialSecG;
    public static float TimeTrialMinS;
    public static float TimeTrialSecS;
    public static float TimeTrialMinB;
    public static float TimeTrialSecB;

    //posicao final
    public static bool Gold = false;
    public static bool Silver = false;
    public static bool Bronze = false;
    public static bool Fail = false;

    //controle
    public static bool Joypad = false;
   
    void Start()
    {
        
    }


    void Update()
    {

        if(Raceover == false){

            
            if(LapChange == true){
            LapChange = false;
            LapTimeMinutes = 0f;
            LapTimeSeconds = 0f;
            GameTime = 0f;
            }

            if(LapNumber >= 1){
            LapTimeSeconds = LapTimeSeconds + 1 * Time.deltaTime;
            RaceTimeSeconds = RaceTimeSeconds + 1 * Time.deltaTime;
            GameTime = GameTime + 1 * Time.deltaTime;
            }

            if(LapTimeSeconds > 59){
                LapTimeSeconds = 0f;
                LapTimeMinutes++;
            }

            if(RaceTimeSeconds > 59){
                RaceTimeSeconds = 0f;
                RaceTimeMinutes++;
            }
        }
        
    }
}
