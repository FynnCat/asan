using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resolution : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionD;

    private UnityEngine.Resolution[] resolutions;
    private List<UnityEngine.Resolution> filteredResolutions;

    private float currentRefreshRate;
    private int currentResolutionIndex = 0;

    // Update is called once per frame
    void Start()
    {
        UnityEngine.Resolution[] resolutions1 = Screen.resolutions;
        resolutions = resolutions1;
        filteredResolutions = new List<UnityEngine.Resolution>();

        resolutionD.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;

        for (int i = 0; i < resolutions.Length; i++)
        { 
            if (resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredResolutions.Add(resolutions1[i]);
            }
        }

        List<string> options = new List<string>();
        for (int i = 0; i < filteredResolutions.Count; i++)
        {
            string resolutionOption = filteredResolutions[i].width + "x" + filteredResolutions[i].height + " " + filteredResolutions[i].refreshRate + " Hz";
            options.Add(resolutionOption);
            if (filteredResolutions[i].width == Screen.width && filteredResolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionD.AddOptions(options);
        resolutionD.value = currentResolutionIndex;
        resolutionD.RefreshShownValue();

    }

    public void SetResolution(int resolutionIndex)
    {
        UnityEngine.Resolution resolution = filteredResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }

}
