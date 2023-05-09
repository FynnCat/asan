using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
  
    public int level;
    public float time;
    public float conpletion;
    public float levelAmount;
    public int levelAmountCompleted;
    public float playerChoice;

    public PlayerData(SaveManager _saveManager)
    {
        conpletion = _saveManager.completion;
        time = _saveManager.time;
        level = _saveManager.level;
        levelAmountCompleted = _saveManager.levelAmountCompleted;
        playerChoice = _saveManager.playerChoice;


    }
}
