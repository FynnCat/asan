using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGameplay()
    {
        Time.timeScale = 0;
        Debug.Log("Paused");
    }

    public void UnpauseGameplay()
    {
        Time.timeScale = 1;
        Debug.Log("Unpaused");
    }
}
