using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Text CreditsText;
    public GameObject StatsPanel;

    void Start(){
        Time.timeScale = 1;
        StartCoroutine(WaitForCredits());
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }

    IEnumerator WaitForCredits(){
        yield return new WaitForSeconds(0.2f);
        CreditsText.text = UniversalSave.CreditAmount.ToString();
    }

    public void SwitchOnStats(){
        StatsPanel.SetActive(true);
    }
}
