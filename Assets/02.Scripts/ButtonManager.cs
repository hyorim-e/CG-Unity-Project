using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region 변수 선언
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

    #region 초기화
    //public void OnClickResetButton(float value)
    public void OnClickResetButton()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        valueText.text = "0%"; // 텍스트 초기화
        //valueText.text = Mathf.RoundToInt(value) + "%"; 

        slider.minValue = 0;
        slider.value = 0;  // 효과 조절 메인 슬라이더 바
        slider1.value = 0;
        slider2.value = 0;
        


        slider.onValueChanged.RemoveAllListeners();
    }
    #endregion

    #region 큐브 버튼
    public void OnCubeButtonClick()
    {

        scenery.SetActive(false);
        cube.SetActive(true);
    }
    #endregion

    #region 풍경 버튼
    public void OnSceneryButtonClick()
    {
        cube.SetActive(false);
        scenery.SetActive(true);
    }
    #endregion

    #region 슬라이더 바 3개

    // Depth of Field, Color Grading 클릭 시 슬라이드 3개 나타나기
    public void OnButtonClick()
    {
        slidersGameObject.SetActive(true);

    } 

    // 그 외 버튼 클릭 시 슬라이드 3개 없애기
    public void OnFourButtonClick()
    {
        slidersGameObject.SetActive(false);
    }
    #endregion
}
