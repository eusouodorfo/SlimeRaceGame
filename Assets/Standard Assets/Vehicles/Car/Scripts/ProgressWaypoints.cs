using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
   //public int WPNumber;
   public int wpNumFromParentTEST;
   public int CarTracking = 0;
   public bool PenaltyOption = false;
   public int PenaltyWayPoint;
   
   private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Progress")){

            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;

            if(CarTracking < wpNumFromParentTEST){
                other.GetComponent<ProgressTracker>().CurrentWP = wpNumFromParentTEST;
                //Debug.Log("CurrentWP =" + other.GetComponent<ProgressTracker>().CurrentWP);
            }
            if(CarTracking > wpNumFromParentTEST){
                //SaveScript.WrongWay = true;
                other.GetComponent<ProgressTracker>().LastWPNumber = wpNumFromParentTEST;
                //Debug.Log("Wrong Way");
            }
            if(PenaltyOption == true){
                if(CarTracking < PenaltyWayPoint){
                    Debug.Log("Penalty");
                }
            }
        }
   }
}
