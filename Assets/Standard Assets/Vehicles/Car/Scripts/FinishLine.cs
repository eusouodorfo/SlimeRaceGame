using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        SaveScript.Raceover = true;
        Time.timeScale = 0.2f;
    }
}
