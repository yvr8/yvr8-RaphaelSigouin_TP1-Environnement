using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Slider = UnityEngine.UI.Slider;
using Toggle = UnityEngine.UI.Toggle;

public class settingMenu : MonoBehaviour
{
    public GameObject menuMain;
    public GameObject menuSetting;
    public Button backButton;
    public TMP_Dropdown dropdown;
    public Slider slider;
    public TMP_InputField inputField;
    public Toggle toggle;    
    
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(Button_click);
        dropdown.onValueChanged.AddListener(Dropdown_OnValueChanged);
        slider.onValueChanged.AddListener(Slider_OnValueChanged);
        inputField.onEndEdit.AddListener(InputField_OnValueChanged);
        toggle.onValueChanged.AddListener(Toggle_OnValueChanged);
        
        menuSetting.SetActive(false);
    }
    
    //Comportement des element de l'UI
    void Button_click()
    {
        menuSetting.SetActive(false);
        menuMain.SetActive(true);
    }
    void Dropdown_OnValueChanged( int value )
    {
        Debug.Log($"Connecter au serveur de {dropdown.options[value].text}");
    }
    void Slider_OnValueChanged( float value )
    {
        Debug.Log($"FOV est maintenant {value}");
    }
    void InputField_OnValueChanged( string value ) 
    {
        Debug.Log($"Vous ete maintenant {value}");
    }
    void Toggle_OnValueChanged( bool value )
    {
        if(value)
            Debug.Log("Bienvenue au chine");
        else
            Debug.Log("Bienvenue en USA");
    }
}
