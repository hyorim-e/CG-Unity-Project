using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[ExecuteInEditMode]
public class PixelateCam : MonoBehaviour
{
    //[Range(1, 100)] public int pixelate;

    public Slider slider;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        source.filterMode = FilterMode.Point;
        RenderTexture resultTexture = RenderTexture.GetTemporary(source.width / (int)slider.value, source.height / (int)slider.value, 0, source.format);
        //RenderTexture resultTexture = RenderTexture.GetTemporary(source.width / pixelate, source.height / pixelate, 0, source.format);
        resultTexture.filterMode = FilterMode.Point;
        Graphics.Blit(source, resultTexture);
        Graphics.Blit(resultTexture, destination);
    }
}
