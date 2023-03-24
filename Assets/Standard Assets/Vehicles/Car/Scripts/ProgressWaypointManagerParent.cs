using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypointManagerParent : MonoBehaviour
{
   
    public ProgressWaypoints[] waypoints;

    void Start()
    {
        Init();
    }

    void Init(){
        waypoints = GetComponentsInChildren<ProgressWaypoints>();
        for(var i = 0; i < waypoints.Length - 1; i++){
            waypoints[i].wpNumFromParentTEST = i + 1;
        }
    }
}
