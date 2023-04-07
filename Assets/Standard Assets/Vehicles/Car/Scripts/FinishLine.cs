using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    public GameObject Leaderboard;
    public string PlayerName;
    public static int PlayerFinishPosition;
    public static string PName;

    private void Start(){
        PName = PlayerName;
    }

    private void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Player")){
            SaveScript.FinishPositionID++;
            PlayerFinishPosition = SaveScript.FinishPositionID;
            SaveScript.Raceover = true;
            Time.timeScale = 0.2f;
            Leaderboard.SetActive(true);
        }
        
    }
}
