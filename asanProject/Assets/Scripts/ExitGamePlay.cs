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
    public int playerChoice, difference;
    // Start is called before the first frame update
    void Start()
    {
        _playerChoiceSlider.minValue = -50;
        _playerChoiceSlider.maxValue = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        difference = playerChoice - _database.PlanetValue;
        if (playerChoice < 0 && difference == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (playerChoice < 0 && difference < 100)
        {
            SceneManager.LoadScene(0);
        }
        if (playerChoice < 0 && _database.PlanetValue == 70)
        {
            SceneManager.LoadScene(0);
        }
        if (playerChoice > 70 && _database.PlanetValue == 50)
        {
            SceneManager.LoadScene(0);
        }

        if (playerChoice > 0 && difference == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (playerChoice > 0 && difference < 100)
        {
            SceneManager.LoadScene(0);
        }
        if (playerChoice > 0 && _database.PlanetValue == 70)
        {
            SceneManager.LoadScene(0);
        }
        if (playerChoice > 70 && _database.PlanetValue == 50)
        {
            SceneManager.LoadScene(0);
        }

    }
}
