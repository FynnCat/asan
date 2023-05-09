using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    public AudioMixer vol;

    public void SetLevel (float sliderValue)
    {
        vol.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
    }
}
