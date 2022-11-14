using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text valueText;
    public Slider slider;

    public GameObject PPCamera;
    public GameObject pixelCamera;

    #region 초기화
    //public void OnClickResetButton(float value)
    public void OnClickResetButton()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        valueText.text = "0%"; // 텍스트 초기화
        //valueText.text = Mathf.RoundToInt(value) + "%"; 

        slider.minValue = 0;
        slider.value = 0;

        slider.onValueChanged.RemoveAllListeners();
    }
    #endregion
}
