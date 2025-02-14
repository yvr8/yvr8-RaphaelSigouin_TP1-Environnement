using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject menuMain;
    public GameObject menuSetting;
    public Button btnStart;
    public Button btnSettings;
    public Button btnQuit;
    void Start()
    {
        btnStart.onClick.AddListener(BtnStart_OnClick);
        btnSettings.onClick.AddListener(BtnSettings_OnClick);
        btnQuit.onClick.AddListener(BtnQuit_OnClick);
        
        menuMain.SetActive(true);
    }
    void BtnStart_OnClick()
    {
        Debug.Log("Start");
    }

    void BtnSettings_OnClick()
    {
        menuSetting.SetActive(true);
        menuMain.SetActive(false);
    }

    void BtnQuit_OnClick()
    {
        Debug.Log("Rage Quit");
    }
}    
