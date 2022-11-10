using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderTest : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        //slider.minValue = 1;
        //slider.maxValue = 100;
        //slider.wholeNumbers = true;
       // slider.value = 1;
    }

    public void OnValueChanged(float value)
    {
        Debug.Log("New Value" + value);
    }
}
