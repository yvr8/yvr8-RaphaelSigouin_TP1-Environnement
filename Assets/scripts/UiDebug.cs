using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiDebug : MonoBehaviour
{
    public Button btnVendreAme;
    public Slider sliderVolume;
    public Toggle toggleThemeSombre;
    public TextMeshProUGUI txtInputed;
    public TMP_InputField inputText;
    public TMP_Dropdown dropdownNSFW;
    // Start is called before the first frame update
    void Start()
    {
        //Lier le btn avec sa fontion
        btnVendreAme.onClick.AddListener(btnVendreAme_OnClick);
        sliderVolume.onValueChanged.AddListener(sliderVolume_OnValueChanged);
        inputText.onEndEdit.AddListener(inputText_OnValueChanged);
        toggleThemeSombre.onValueChanged.AddListener(toggleThemeSombre_OnValueChanged);
        dropdownNSFW.onValueChanged.AddListener(dropdownNSFW_OnValueChanged);
    }  
    
    void btnVendreAme_OnClick()
    {
        Debug.Log("Ame vendue");
    }

    void sliderVolume_OnValueChanged(float value)  
    {
        Debug.Log( "Volume changed to " + value );
    }

    void toggleThemeSombre_OnValueChanged(bool value)
    {
        Debug.Log( "Theme changed to " + value );
    }

    void inputText_OnValueChanged(string text)
    {
        txtInputed.text = text;
        Debug.Log( "Text changed to " + text );
    }

    void dropdownNSFW_OnValueChanged(int value)
    {
        Debug.Log( "NSFW changed to " + value + "and text is" + dropdownNSFW.options[value].text);
    }
}
