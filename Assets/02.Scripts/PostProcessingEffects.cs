using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessingEffects : MonoBehaviour
{
    public PostProcessVolume volume;

    private Bloom _Bloom;
    private Vignette _Vignette;
    private ChromaticAberration _Chromatic;
    private DepthOfField _DepthOfField;
    private ColorGrading _ColorGrading;

    public Slider slider;

    public GameObject PPCamera;
    public GameObject pixelCamera;

    void Start()
    {
        volume.profile.TryGetSettings(out _Bloom);
        volume.profile.TryGetSettings(out _Vignette);
        volume.profile.TryGetSettings(out _Chromatic);
        volume.profile.TryGetSettings(out _DepthOfField);
        volume.profile.TryGetSettings(out _ColorGrading);

        //volume.profile.RemoveSettings<DepthOfField>(); // 옵션 삭제
        //volume.profile.AddSettings<DepthOfField>(); // 옵션 추가
    }

    void Update()
    {
        //_Bloom.intensity.value = Mathf.Lerp(_Bloom.intensity.value, 15, .5f * Time.deltaTime);
        //_Vignette.intensity.value = Mathf.Lerp(_Vignette.intensity.value, 15, .05f * Time.deltaTime);
    }
    #region Pixelate
    public void PixelateClick()
    {
        //PixelateOn = true;
        slider.minValue = 1;
        slider.onValueChanged.RemoveAllListeners();
        PPCamera.SetActive(false);
        pixelCamera.SetActive(true);
        slider.value = 0;
    }
    #endregion

    #region Bloom
    public void BloomClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider.minValue = 0;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { Bloom(); });
        //slider.onValueChanged.AddListener(Bloom); // 함수 이름만 쓸 때는 반드시 Float형 변수 하나를 매개 변수로 가지고 있어야 함.

        _Bloom.intensity.value = 0;
        _Vignette.intensity.value = 0;
        _Chromatic.intensity.value = 0;
    }

    public void Bloom()
    {
        _Bloom.intensity.value = slider.value;
    }
    #endregion

    #region Vignette
    public void VignetteClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider.minValue = 0;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { Vignette(); });

        _Bloom.intensity.value = 0;
        _Vignette.intensity.value = 0;
        _Chromatic.intensity.value = 0;
    }

    public void Vignette()
    {
        _Vignette.intensity.value = slider.value;
    }
    #endregion

    #region Chromatic Aberration
    public void ChromaticClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider.minValue = 0;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { Chromatic(); });

        _Bloom.intensity.value = 0;
        _Vignette.intensity.value = 0;
        _Chromatic.intensity.value = 0;
    }

    public void Chromatic()
    {
        _Chromatic.intensity.value = slider.value / 100;
    }
    #endregion

    #region Depth of Field
    public void DepthOfFieldClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        _DepthOfField.enabled.Override(true);
        _DepthOfField.focusDistance.Override(.1f);

        slider.minValue = .1f;
        slider.maxValue = 300;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { DepthOfField(); });

        _Bloom.intensity.value = 0;
        _Vignette.intensity.value = 0;
        _Chromatic.intensity.value = 0;
        _DepthOfField.focusDistance.value = 0;
    }

    public void DepthOfField()
    {
        _DepthOfField.focusDistance.value = slider.value;
    }
    #endregion

    #region Color Grading
    public void ColorGradingClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider.minValue = -180;
        slider.maxValue = 180;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { ColorGrading(); });

        _Bloom.intensity.value = 0;
        _Vignette.intensity.value = 0;
        _Chromatic.intensity.value = 0;
        _DepthOfField.focusDistance.value = 0;
        _ColorGrading.hueShift.value = 0;
    }

    public void ColorGrading()
    {
        _ColorGrading.hueShift.value = slider.value;
    }
    #endregion
}
