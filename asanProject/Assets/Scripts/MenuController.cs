using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject _Database;
    [SerializeField] GameObject _gamePlay;
    [SerializeField] bool _databaseOpen;
    // Start is called before the first frame update
    void Start()
    {
        
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

        }
        else
        {
            _gamePlay.SetActive(true);
            _Database.SetActive(false);
            _databaseOpen = false;
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
