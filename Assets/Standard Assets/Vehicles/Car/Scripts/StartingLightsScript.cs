using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLightsScript : MonoBehaviour
{
    public GameObject RlightOff;
    public GameObject RlightOn;
    public GameObject YlightOff;
    public GameObject YlightOn;
    public GameObject GlightOff;
    public GameObject GlightOn;

    void Start(){
        RlightOff.SetActive(true);
        YlightOff.SetActive(true);
        GlightOff.SetActive(true);
        RlightOn.SetActive(false);
        YlightOn.SetActive(false);
        GlightOn.SetActive(false);
        StartCoroutine(StartingLights());
    }

    IEnumerator StartingLights(){
        
        yield return new WaitForSeconds(1f);
        RlightOff.SetActive(false);
        RlightOn.SetActive(true);
        yield return new WaitForSeconds(1f);
        RlightOff.SetActive(true);
        RlightOn.SetActive(false);
        YlightOff.SetActive(false);
        YlightOn.SetActive(true);
        yield return new WaitForSeconds(1f);
        YlightOff.SetActive(true);
        YlightOn.SetActive(false);
        GlightOff.SetActive(false);
        GlightOn.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SaveScript.RaceStart = true;
        yield return new WaitForSeconds(0.5f);
        GlightOff.SetActive(true);
        GlightOn.SetActive(false);

    }
}
