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
    public int playerChoice;
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
        if (_database.PlanetValue < 30 && _database.PlanetValue > 0)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue > 30 && _database.PlanetValue < 50)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue > 50 && _database.PlanetValue < 70)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue > 70 && _database.PlanetValue < 100)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue < 0 && _database.PlanetValue < -30)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue < -30 && _database.PlanetValue > -50)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue < -50 && _database.PlanetValue > -70)
        {
            SceneManager.LoadScene(0);
        }
        if (_database.PlanetValue < -70 && _database.PlanetValue > -30)
        {
            SceneManager.LoadScene(0);
        }

    }
}
