using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resolution : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionD;

    private UnityEngine.Resolution[] resolutions;
    private List<Resolution> filteredResolutions;

    private float currentRefreshRate;
    private int currentResolutionIndex = 0;

    // Update is called once per frame
    void Start()
    {
        UnityEngine.Resolution[] resolutions1 = Screen.resolutions;
        resolutions = resolutions1;
        filteredResolutions = new List<Resolution>();

        resolutionD.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;

        for (int i = 0, i < resolutions.Length; i++)
        { 
            if (resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredResolutions.Add(resolutions[i]);
            }
        }

    }
}
