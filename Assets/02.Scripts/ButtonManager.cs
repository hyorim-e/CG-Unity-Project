using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region ���� ����
    public Text sliderText1;
    public Text sliderText2;
    public Text sliderText3;

    Text sliderText;

    public GameObject cube;
    public GameObject scenery;

    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    public GameObject slider1_obj;
    public GameObject slider2_obj;
    public GameObject slider3_obj;

    public GameObject PPCamera;
    public GameObject pixelCamera;
    #endregion

    #region �����̴� �ؽ�Ʈ ������Ʈ
    public void valueUpdate()
    {
        sliderText1.text = (Mathf.RoundToInt(slider1.value)).ToString();
        sliderText2.text = (Mathf.RoundToInt(slider2.value)).ToString();
        sliderText3.text = (Mathf.RoundToInt(slider3.value)).ToString();
    }
    #endregion

    #region �ʱ�ȭ
    //public void OnClickResetButton(float value)
    public void OnClickResetButton()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider1.onValueChanged.RemoveAllListeners();
        slider2.onValueChanged.RemoveAllListeners();
        slider3.onValueChanged.RemoveAllListeners();

        // �ؽ�Ʈ �ʱ�ȭ
        sliderText1.text = "0";
        sliderText2.text = "0";
        sliderText3.text = "0";
        //valueText.text = Mathf.RoundToInt(value) + "%"; 
        
        slider1.minValue = 0;
        slider2.minValue = 0;
        slider3.minValue = 0;

        slider1.maxValue = 100;
        slider2.maxValue = 100;
        slider3.maxValue = 100;

        slider3.value = 0;
        slider1.value = 0;
        slider2.value = 0;
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

    #region �����̴� �� 3��

    // Depth of Field, Color Grading Ŭ�� �� �����̵� 3�� ��Ÿ����
    public void OnButtonClick()
    {
        slider1_obj.SetActive(true);
        slider2_obj.SetActive(true);
    } 

    // �� �� ��ư Ŭ�� �� �����̵� 3�� ���ֱ�
    public void OnFourButtonClick()
    {
        slider1_obj.SetActive(false);
        slider2_obj.SetActive(false);
    }
    #endregion

    #region ������ ��ư
    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
    #endregion
}
