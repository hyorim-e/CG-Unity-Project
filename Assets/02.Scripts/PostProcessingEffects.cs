using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessingEffects : MonoBehaviour
{
    #region 변수 선언
    public PostProcessVolume volume;

    private Bloom _Bloom;
    private Vignette _Vignette;
    private ChromaticAberration _Chromatic;
    private DepthOfField _DepthOfField;
    private ColorGrading _ColorGrading;

    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    public GameObject PPCamera;
    public GameObject pixelCamera;
    #endregion

    void Start()
    {
        volume.profile.TryGetSettings(out _Bloom);
        volume.profile.TryGetSettings(out _Vignette);
        volume.profile.TryGetSettings(out _Chromatic);
        volume.profile.TryGetSettings(out _DepthOfField);
        volume.profile.TryGetSettings(out _ColorGrading);

        //volume.profile.RemoveSettings<DepthOfField>();
        //volume.profile.AddSettings<DepthOfField>();
        //_DepthOfField.enabled.Override(true);
        //_DepthOfField.focusDistance.Override(.1f);
    }

    void Update()
    {
        //_Bloom.intensity.value = Mathf.Lerp(_Bloom.intensity.value, 15, .5f * Time.deltaTime);
        //_Vignette.intensity.value = Mathf.Lerp(_Vignette.intensity.value, 15, .05f * Time.deltaTime);
    }
    #region Pixelate
    public void PixelateClick()
    {
        slider3.onValueChanged.RemoveAllListeners(); ;
        slider3.minValue = 1;
        slider3.maxValue = 100;
        slider3.value = slider3.minValue;

        PPCamera.SetActive(false);
        pixelCamera.SetActive(true);
    }
    #endregion

    #region Bloom
    public void BloomClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider3.onValueChanged.RemoveAllListeners();
        slider3.minValue = 0;
        slider3.maxValue = 100;
        slider3.value = _Bloom.intensity.value;
        slider3.onValueChanged.AddListener(delegate { Bloom(); });
        //slider.onValueChanged.AddListener(Bloom); // 함수 이름만 쓸 때는 반드시 Float형 변수 하나를 매개 변수로 가지고 있어야 함.

        //_Bloom.intensity.value = 0;
        //_Vignette.intensity.value = 0;
        //_Chromatic.intensity.value = 0;
    }

    public void Bloom()
    {
        _Bloom.intensity.value = slider3.value / 10;
    }
    #endregion

    #region Vignette
    public void VignetteClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider3.onValueChanged.RemoveAllListeners();
        slider3.minValue = 0;
        slider3.maxValue = 100;
        slider3.value = _Vignette.intensity.value;
        slider3.onValueChanged.AddListener(delegate { Vignette(); });

        //_Bloom.intensity.value = 0;
        //_Vignette.intensity.value = 0;
        //_Chromatic.intensity.value = 0;
    }

    public void Vignette()
    {
        _Vignette.intensity.value = slider3.value / 100;
    }
    #endregion

    #region Chromatic Aberration(색 수차)
    public void ChromaticClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider3.onValueChanged.RemoveAllListeners();
        slider3.minValue = 0;
        slider3.maxValue = 100;
        slider3.value = _Chromatic.intensity.value;
        slider3.onValueChanged.AddListener(delegate { Chromatic(); });

        //_Bloom.intensity.value = 0;
        //_Vignette.intensity.value = 0;
        //_Chromatic.intensity.value = 0;
    }

    public void Chromatic()
    {
        _Chromatic.intensity.value = slider3.value / 100;
    }
    #endregion

    #region Depth of Field(피사계 심도)
    public void DepthOfFieldClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        // Focus Distance
        slider1.onValueChanged.RemoveAllListeners();
        slider1.minValue = .1f;
        slider1.maxValue = 300;
        slider1.value = _DepthOfField.focusDistance.value;
        slider1.onValueChanged.AddListener(delegate { DepthOfField_FocusDistance(); });

        // Aperture
        slider2.onValueChanged.RemoveAllListeners();
        slider2.minValue = .1f;
        slider2.maxValue = 32;
        slider2.value = _DepthOfField.aperture.value;
        slider2.onValueChanged.AddListener(delegate { DepthOfField_Aperture(); });

        // Focal Length
        slider3.onValueChanged.RemoveAllListeners();
        slider3.minValue = 1;
        slider3.maxValue = 300;
        slider3.value = _DepthOfField.focalLength.value;
        slider3.onValueChanged.AddListener(delegate { DepthOfField_FocalLength(); });

        //_Bloom.intensity.value = 0;
        //_Vignette.intensity.value = 0;
        //_Chromatic.intensity.value = 0;
        //_DepthOfField.focusDistance.value = 0;
    }

    // 세부 옵션
    public void DepthOfField_FocusDistance()
    {
        _DepthOfField.focusDistance.value = slider1.value;
    }
    public void DepthOfField_Aperture()
    {
        _DepthOfField.aperture.value = slider2.value;
    }
    public void DepthOfField_FocalLength()
    {
        _DepthOfField.focalLength.value = slider3.value;
    }
    #endregion

    #region Color Grading(컬러 분류)
    public void ColorGradingClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        // Hue Shift
        slider1.onValueChanged.RemoveAllListeners();
        slider1.minValue = -180;
        slider1.maxValue = 180;
        slider1.value = _ColorGrading.hueShift.value;
        slider1.onValueChanged.AddListener(delegate { ColorGrading_HueShift(); });

        // Saturation
        slider2.onValueChanged.RemoveAllListeners();
        slider2.minValue = -100;
        slider2.maxValue = 100;
        slider2.value = _ColorGrading.saturation.value;
        slider2.onValueChanged.AddListener(delegate { ColorGrading_Saturation(); });

        // Contrast
        slider3.onValueChanged.RemoveAllListeners();
        slider3.minValue = -100;
        slider3.maxValue = 100;
        slider3.value = _ColorGrading.contrast.value;
        slider3.onValueChanged.AddListener(delegate { ColorGrading_Contrast(); });

        //_Bloom.intensity.value = 0;
        //_Vignette.intensity.value = 0;
        //_Chromatic.intensity.value = 0;
        //_DepthOfField.focusDistance.value = 0;
        //_ColorGrading.hueShift.value = 0;
    }

    public void ColorGrading_HueShift()
    {
        _ColorGrading.hueShift.value = slider1.value;
    }
    public void ColorGrading_Saturation()
    {
        _ColorGrading.saturation.value = slider2.value;
    }
    public void ColorGrading_Contrast()
    {
        _ColorGrading.contrast.value = slider3.value;
    }
    #endregion

    #region 적용된 값 초기화
    public void PostProcessingReset()
    {
        _Bloom.intensity.value = 0;

        _Vignette.intensity.value = 0;

        _Chromatic.intensity.value = 0;

        _DepthOfField.focusDistance.value = .1f;
        _DepthOfField.aperture.value = .1f;
        _DepthOfField.focalLength.value = 1;

        _ColorGrading.hueShift.value = 0;
        _ColorGrading.saturation.value = 0;
        _ColorGrading.contrast.value = 0;
    }
    #endregion
}
