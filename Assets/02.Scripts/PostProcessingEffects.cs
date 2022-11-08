using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessingEffects : MonoBehaviour
{
    public PostProcessVolume volume;

    private Bloom _Bloom;

    public Slider slider;
    public Button BloomBtn;

    bool isBloomBtn = false;

    void Start()
    {
        volume.profile.TryGetSettings(out _Bloom);

        _Bloom.intensity.value = 0; 
    }

    void Update()
    {
        if (isBloomBtn) { }
       // _Bloom.intensity.value = slider.value;
    }
    
    void IsBloomBtn()
    {
        isBloomBtn = true;

    }
}
