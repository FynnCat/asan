using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveSceneScript : MonoBehaviour
{
    public float time;
    [SerializeField] int _scannableItems;
    public int _numberOfItemsScanned;
    public float percentage;
    public int addrepuation;
    public int reputation;
    public int amountUntilNextLevel;
    public Database database;
    public ExitGamePlay exitGamePlay;
    public int level;
    [SerializeField] RandomPlacement _randomPlacement;
    public float _stopwatch;
    [SerializeField] SaveManager _saveManager;
    [SerializeField] ExitGamePlay _exitGamePlay;
    public int planetValue;
    public float playersChoice;
    [SerializeField] Database _database;
    // Start is called before the first frame update
    void Start()
    {
        _randomPlacement = GameObject.FindObjectOfType<RandomPlacement>();
        _scannableItems = _randomPlacement.objects2.Length + 1;
        _exitGamePlay = GameObject.FindObjectOfType<ExitGamePlay>();


    }

    // Update is called once per frame
    void Update()
    {
        planetValue = _database.PlanetValue;
        //PlayersChoice. 
        playersChoice = _exitGamePlay.playerChoice;
        //Debug.Log(playersChoice);
        _stopwatch += Time.deltaTime;
        
        if (_numberOfItemsScanned != 0)
        Debug.Log( "Result " + (_scannableItems / _numberOfItemsScanned));            

    }

    public void EndGameplay()
    {
        
        if (database.PlanetValue - exitGamePlay.playerChoice > 50)
        {
            //addrepuation = 3;
        }
        else if (database.PlanetValue - exitGamePlay.playerChoice < 50)
        {
            level++;
        }
            amountUntilNextLevel = amountUntilNextLevel - addrepuation;
        if (amountUntilNextLevel < 0)
        {
            level++;
            amountUntilNextLevel = (level + 20) * 6;
        }

        //Working out percentage.]
        Debug.Log("Percentage: " + percentage);
        percentage = ( (float)_numberOfItemsScanned / (float)_scannableItems) * 100;
        Debug.Log("New percentage: " + percentage);

        //Time.
        time = _stopwatch;

        //PlanetValue.
        
        Debug.Log(planetValue);

        

        _exitGamePlay.SaveSelection();

        
    }

    public void EndMenuGameplay()
    {
        if (_exitGamePlay._endPanelActive == false)
        {
            _exitGamePlay._endPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            _exitGamePlay._endPanelActive = true;
            _exitGamePlay._pauseGame.PauseGameplay();
        }
    }


}
