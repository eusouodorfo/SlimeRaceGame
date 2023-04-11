using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCount;
    
    void Start(){
        DontDestroyOnLoad(this);
    }
}
