using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveSceneScript : MonoBehaviour
{
    public float time;
    [SerializeField] int _scannableItems;
    [SerializeField] int _numberOfItemsScanned;
    public float percentage;
    public int addrepuation;
    public int reputation;
    public int amountUntilNextLevel;
    public Database database;
    public ExitGamePlay exitGamePlay;
    public int level;
    [SerializeField] RandomPlacement _randomPlacement;
    [SerializeField] float _stopwatch;

    // Start is called before the first frame update
    void Start()
    {
        _randomPlacement = GameObject.FindObjectOfType<RandomPlacement>();
        _scannableItems = _randomPlacement.objects2.Length + 1;

    }

    // Update is called once per frame
    void Update()
    {
        _stopwatch += Time.deltaTime;
    }

    void EndGameplay()
    {
        if (database.PlanetValue - exitGamePlay.playerChoice > 50)
        {
            addrepuation = 3;
        }
        else if (database.PlanetValue - exitGamePlay.playerChoice < 50)
        {
            reputation = 7;
        }
            amountUntilNextLevel = amountUntilNextLevel - addrepuation;
        if (amountUntilNextLevel < 0)
        {
            level++;
            amountUntilNextLevel = (level + 20) * 6;
        }

        //Working out percentage.
        percentage = (_numberOfItemsScanned/_scannableItems) * 100;

        //Time.
        time = _stopwatch;
        
    }


}
