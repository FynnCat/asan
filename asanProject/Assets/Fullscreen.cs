using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    public Toggle fTog;

    public void Toggle()
    {
        if (fTog.isOn)
        {
            Screen.fullScreen = !Screen.fullScreen;
            Debug.Log("Fullscreen");
        }
        if(fTog.isOn == false)
        {
            Screen.fullScreen = !Screen.fullScreen;
            Debug.Log("Off");
        }
    }

    private void Update()
    {
        
    }
}
