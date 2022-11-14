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
    //private _;

    public Slider slider;

    public GameObject PPCamera;
    public GameObject pixelCamera;

    void Start()
    {
        volume.profile.TryGetSettings(out _Bloom);
        volume.profile.TryGetSettings(out _Vignette);
        //volume.profile.TryGetSettings(out _);
    }

    void Update()
    {
        //_Bloom.intensity.value = Mathf.Lerp(_Bloom.intensity.value, 15, .5f * Time.deltaTime);
        //_Vignette.intensity.value = Mathf.Lerp(_Vignette.intensity.value, 15, .05f * Time.deltaTime);
    }

    public void PixelateClick()
    {
        //PixelateOn = true;
        slider.minValue = 1;
        slider.onValueChanged.RemoveAllListeners();
        PPCamera.SetActive(false);
        pixelCamera.SetActive(true);
        //slider.onValueChanged.AddListener(delegate { Pixelate(); });
        slider.value = 0;
    }

    public void BloomClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider.minValue = 0;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { Bloom(); });
        //slider.onValueChanged.AddListener(Bloom); // 함수 이름만 쓸 때는 반드시 Float형 변수 하나를 매개 변수로 가지고 있어야 함.
        
        _Bloom.intensity.value = 0;
    }

    public void Bloom()
    {
        _Bloom.intensity.value = slider.value;
    }

    public void VignetteClick()
    {
        PPCamera.SetActive(true);
        pixelCamera.SetActive(false);

        slider.minValue = 0;
        slider.onValueChanged.RemoveAllListeners();
        slider.onValueChanged.AddListener(delegate { Vignette(); });

        _Vignette.intensity.value = 0;
    }

    public void Vignette()
    {
        _Vignette.intensity.value = slider.value;
    }
}
