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
    [SerializeField] GameObject _endPanel;
    public float playerChoice;
    [SerializeField] bool _endPanelActive = false;
    [SerializeField] SaveManager _saveManager;
    [SerializeField] saveSceneScript _saveSceneScript;

    // Start is called before the first frame update
    void Start()
    {
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
            SceneManager.LoadScene(6);
        }
        if (_database.PlanetValue > 30 && _database.PlanetValue < 50 && playerChoice < -1)
        {
            Debug.Log("4");
            SceneManager.LoadScene(4);
        }
        if (_database.PlanetValue > 50 && _database.PlanetValue < 70 && playerChoice < -1)
        {
            Debug.Log("3");
            SceneManager.LoadScene(3);
        }
        if (_database.PlanetValue > 70 && _database.PlanetValue < 100 && playerChoice > 1)
        {
            Debug.Log("5");
            SceneManager.LoadScene(5);
        }
        if (_database.PlanetValue > 70 && _database.PlanetValue < 100 && playerChoice > 1)
        {
            Debug.Log("8");
            SceneManager.LoadScene(8);
        }
        if (_database.PlanetValue == 0)
        {
            Debug.Log("N");
        }
        if (_database.PlanetValue < 0 && _database.PlanetValue < -30 && playerChoice > 1)
        {
            Debug.Log("7");
            SceneManager.LoadScene(7);
        }
        if (_database.PlanetValue < -30 && _database.PlanetValue > -50 && playerChoice < -1)
        {
            Debug.Log("2");
            SceneManager.LoadScene(2);
        }
        if(_database.PlanetValue > -50 && _database.PlanetValue < -100 && playerChoice < -1)
        {
            Debug.Log("1");
            SceneManager.LoadScene(1);
        }

    }

    public void EndExploration()
    {
        if (_endPanelActive == false)
        {
            _endPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            _endPanelActive = true;
        }
    }

    public void SaveSelection()
    {
        Debug.Log("F you");
        if (_endPanelActive == true)
        {

            Debug.Log("Saving...");
           _saveManager.time = _saveSceneScript.time;
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
