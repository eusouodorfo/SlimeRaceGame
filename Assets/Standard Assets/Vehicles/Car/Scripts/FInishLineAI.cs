using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineAI : MonoBehaviour
{
    public bool AI1;
    public bool AI2;
    public bool AI3;
    public bool AI4;
    public bool AI5;
    public bool AI6;
    public bool AI7;
    public string CarName;

    //carro 1
    public static int AICar1FinishPosition;
    public static string AICar1Name;
    public static float AICar1RTMinutes;
    public static float AICar1RTSeconds;

    //carro 2
    public static int AICar2FinishPosition;
    public static string AICar2Name;
    public static float AICar2RTMinutes;
    public static float AICar2RTSeconds;

    //carro 3
    public static int AICar3FinishPosition;
    public static string AICar3Name;
    public static float AICar3RTMinutes;
    public static float AICar3RTSeconds;

    //carro 4
    public static int AICar4FinishPosition;
    public static string AICar4Name;
    public static float AICar4RTMinutes;
    public static float AICar4RTSeconds;

    //carro 5
    public static int AICar5FinishPosition;
    public static string AICar5Name;
    public static float AICar5RTMinutes;
    public static float AICar5RTSeconds;

    //carro 6
    public static int AICar6FinishPosition;
    public static string AICar6Name;
    public static float AICar6RTMinutes;
    public static float AICar6RTSeconds;

    //carro 7
    public static int AICar7FinishPosition;
    public static string AICar7Name;
    public static float AICar7RTMinutes;
    public static float AICar7RTSeconds;

    private void OnTriggerEnter(Collider other){

        //CARRO 1
        if(AI1 == true){
            if(other.gameObject.CompareTag("ProgressAI1")){
                SaveScript.FinishPositionID++;   
                AICar1FinishPosition = SaveScript.FinishPositionID; 
                AICar1Name = CarName;
                AICar1RTMinutes = SaveScript.RaceTimeMinutes;
                AICar1RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        //CARRO 2
        if(AI2 == true){
            if(other.gameObject.CompareTag("ProgressAI2")){
                SaveScript.FinishPositionID++;   
                AICar2FinishPosition = SaveScript.FinishPositionID; 
                AICar2Name = CarName;
                AICar2RTMinutes = SaveScript.RaceTimeMinutes;
                AICar2RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        //CARRO 3
        if(AI3 == true){
            if(other.gameObject.CompareTag("ProgressAI3")){
                SaveScript.FinishPositionID++;   
                AICar3FinishPosition = SaveScript.FinishPositionID; 
                AICar3Name = CarName;
                AICar3RTMinutes = SaveScript.RaceTimeMinutes;
                AICar3RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        //CARRO 4
        if(AI4 == true){
            if(other.gameObject.CompareTag("ProgressAI4")){
                SaveScript.FinishPositionID++;   
                AICar4FinishPosition = SaveScript.FinishPositionID; 
                AICar4Name = CarName;
                AICar4RTMinutes = SaveScript.RaceTimeMinutes;
                AICar4RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        //CARRO 5
        if(AI5 == true){
            if(other.gameObject.CompareTag("ProgressAI5")){
                SaveScript.FinishPositionID++;   
                AICar5FinishPosition = SaveScript.FinishPositionID; 
                AICar5Name = CarName;
                AICar5RTMinutes = SaveScript.RaceTimeMinutes;
                AICar5RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        //CARRO 6
        if(AI6 == true){
            if(other.gameObject.CompareTag("ProgressAI6")){
                SaveScript.FinishPositionID++;   
                AICar6FinishPosition = SaveScript.FinishPositionID; 
                AICar6Name = CarName;
                AICar6RTMinutes = SaveScript.RaceTimeMinutes;
                AICar6RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

        //CARRO 7
        if(AI7 == true){
            if(other.gameObject.CompareTag("ProgressAI7")){
                SaveScript.FinishPositionID++;   
                AICar7FinishPosition = SaveScript.FinishPositionID; 
                AICar7Name = CarName;
                AICar7RTMinutes = SaveScript.RaceTimeMinutes;
                AICar7RTSeconds = SaveScript.RaceTimeSeconds;
            }
        }

    }
}
