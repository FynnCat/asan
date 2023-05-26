using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject _Database;
    [SerializeField] GameObject _gamePlay;
    [SerializeField] bool _databaseOpen;
    [SerializeField] PauseGame _pauseGame;
    // Start is called before the first frame update
    void Start()
    {
        _pauseGame = GameObject.FindObjectOfType<PauseGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void Database()
    {
        Debug.Log("Open");
        
        if (_databaseOpen == false)
        {
            _Database.SetActive(true);
        _gamePlay.SetActive(false);
            _databaseOpen = true;
            _pauseGame.PauseGameplay();

        }
        else
        {
            _gamePlay.SetActive(true);
            _Database.SetActive(false);
            _databaseOpen = false;
            _pauseGame.UnpauseGameplay();
        }
    }
    IEnumerator WaitTime()
    {
        //Animation.
        yield return new WaitForSeconds(2f);
        //Do thing.
        yield return new WaitForSeconds(2f);
        //Set bool.

    }
}
