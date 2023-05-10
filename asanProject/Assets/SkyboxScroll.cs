using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxScroll : MonoBehaviour
{

    public float skyboxSpeed = 1.2f;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxSpeed);
    }
}
