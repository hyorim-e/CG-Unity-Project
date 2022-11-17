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
    public GameObject cube;
    public GameObject scenery;
    public Slider slider1;
    public Slider slider2;
    public GameObject slidersGameObject;

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
        slider.value = 0;  // ȿ�� ���� ���� �����̴� ��
        slider1.value = 0;
        slider2.value = 0;
        


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

    #region �����̴� �� 3��

    // Depth of Field, Color Grading Ŭ�� �� �����̵� 3�� ��Ÿ����
    public void OnButtonClick()
    {
        slidersGameObject.SetActive(true);

    } 

    // �� �� ��ư Ŭ�� �� �����̵� 3�� ���ֱ�
    public void OnFourButtonClick()
    {
        slidersGameObject.SetActive(false);
    }
    #endregion
}
