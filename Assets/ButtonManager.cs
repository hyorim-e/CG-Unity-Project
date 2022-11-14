using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Text valueText;
    public Slider slider;

    
    void Start()
    {
        valueText = GetComponent<Text>();
    }
    #region √ ±‚»≠
    public void ResetText(float value)
    {
        valueText.text = Mathf.RoundToInt(value) + "%";
    }


    public void OnClickResetButton(float value)
    {
        // slider.minValue = 0;
        slider.value = 0;
    }

#endregion

    void Update()
    {
        
    }
}
