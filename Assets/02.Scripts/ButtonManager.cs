using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region ���� ����
    public Text valueText;
    public Slider slider;
    public Slider slider_1;
    public Slider slider_2;
    public Slider slider_3;
    public GameObject cube;
    public GameObject scenery;

    public GameObject PPCamera;
    public GameObject pixelCamera;
    #endregion

    #region �ʱ�ȭ
    //public void OnClickResetButton(float value)
    public void OnClickResetButton()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        valueText.text = "0%"; // �ؽ�Ʈ �ʱ�ȭ
        //valueText.text = Mathf.RoundToInt(value) + "%"; 

        slider.minValue = 0;
        slider.value = 0;

        slider.onValueChanged.RemoveAllListeners();
    }
    #endregion

    #region ť�� ��ư
    public void OnCubeButtonClick()
    {

        scenery.SetActive(false);
        cube.SetActive(true);
    }
    #endregion

    #region ǳ�� ��ư
    public void OnSceneryButtonClick()
    {
        cube.SetActive(false);
        scenery.SetActive(true);
    }
    #endregion
}
