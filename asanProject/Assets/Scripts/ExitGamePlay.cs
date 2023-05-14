using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitGamePlay : MonoBehaviour
{
    [SerializeField] Database _database;
    [SerializeField] Slider _playerChoiceSlider;
    public GameObject _endPanel;
    public float playerChoice;
    public bool _endPanelActive = false;
    [SerializeField] SaveManager _saveManager;
    [SerializeField] saveSceneScript _saveSceneScript;
    public Scene LeaveScene1, LeaveScene2, LeaveScene3, LeaveScene4, LeaveScene5, LeaveScene6, LeaveScene7, LeaveScene8;

    // Start is called before the first frame update
    void Start()
    {
        _saveSceneScript = GameObject.FindObjectOfType<saveSceneScript>();
        _saveManager = GameObject.FindObjectOfType<SaveManager>();
        _playerChoiceSlider.minValue = -50;
        _playerChoiceSlider.maxValue = 50;
    }

    // Update is called once per frame
    void Update()
    {
        playerChoice = _playerChoiceSlider.value;
    }

    public void EndGame()
    {
        
        
        if (_database.PlanetValue < 30 && _database.PlanetValue > 0 && playerChoice > 1)
        {
            Debug.Log("6");
            SceneManager.LoadScene("Y_LeaveScene_002");
        }
        if (_database.PlanetValue > 30 && _database.PlanetValue < 50 && playerChoice < -1)
        {
            Debug.Log("4");
            SceneManager.LoadScene("N_LeaveScene_004");
        }
        if (_database.PlanetValue > 30 && _database.PlanetValue < 50 && playerChoice < 1)
        {
            Debug.Log("4");
            SceneManager.LoadScene("Y_LeaveScene_002");
        }
        if (_database.PlanetValue > 50 && _database.PlanetValue < 70 && playerChoice < -1)
        {
            Debug.Log("3");
            SceneManager.LoadScene("N_LeaveScene_003");
        }
        if (_database.PlanetValue >= 70 && _database.PlanetValue < 100 && playerChoice > 1)
        {
            Debug.Log("5");
            SceneManager.LoadScene("Y_LeaveScene_001");
        }
        if (_database.PlanetValue >= 70 && _database.PlanetValue < 100 && playerChoice > 1)
        {
            Debug.Log("8");
            SceneManager.LoadScene("Y_LeaveScene_004");
        }
        if (_database.PlanetValue == 0)
        {
            Debug.Log("N");
            SceneManager.LoadScene("N_LeaveScene_001");
        }
        if (_database.PlanetValue < 0 && _database.PlanetValue < -30 && playerChoice > 1)
        {
            Debug.Log("7");
            SceneManager.LoadScene("Y_LeaveScene_003");
        }
        if (_database.PlanetValue < -30 && _database.PlanetValue > -50 && playerChoice < -1)
        {
            Debug.Log("2");
            SceneManager.LoadScene("N_LeaveScene_002");
        }
        if(_database.PlanetValue > -50 && _database.PlanetValue < -100 && playerChoice < -1)
        {
            Debug.Log("1");
            SceneManager.LoadScene("N_LeaveScene_001");
        }

        else
        {
            Debug.Log("1");
            SceneManager.LoadScene("N_LeaveScene_001");
        }

    }

    public void EndExploration()
    {
        
    }

    public void SaveSelection()
    {
        Debug.Log("F you");
        if (_endPanelActive == true)
        {

            Debug.Log("Saving...");
           _saveManager.time = _saveSceneScript._stopwatch;
           _saveManager.completion = _saveSceneScript.percentage;
           _saveManager.level = _saveSceneScript.level;
            _saveManager.levelAmountCompleted = _saveSceneScript.amountUntilNextLevel;
            SaveSystem.SaveMoney(_saveManager);

            Debug.Log("??????");
            EndGame();
        }
    }

    public void CloseEndPanel()
    {
        Debug.Log("Started Closing...");
        if (_endPanelActive == true)
        {
            Debug.Log("Entered the if");
            _endPanel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            _endPanelActive = false;
        }
    }

}
