using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    [SerializeField] SaveManager _saveManager;
    [SerializeField] saveSceneScript _saveSceneScript;

    //[SerializeField] GunUpgrade _gunUpgrade;
    public float time;
    public float completion;
    public int level;
    public float levelAmount;
    public int levelAmountCompleted;
    public float playerChoice;
    public int planetValue;
    string path;
    public bool LoadScene = false;
    [SerializeField] string scene;

    // Start is called before the first frame update
    void Start()
    {
         
         scene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        playerChoice = _saveSceneScript.playersChoice;
        planetValue = _saveSceneScript.planetValue;

        PlayerData data = SaveSystem.LoadMoney();
        if (scene == "FynnScene")
        {
            _saveSceneScript.level = data.level;
            return;
        }

        if (data != null)
        {
            Debug.Log(data.level + "\n" + data.time + "\n" + data.conpletion + "\n" + data.planetValue + "\n" + data.playerChoice);
            _saveSceneScript.level = data.level;
            _saveSceneScript.time = data.time;
            _saveSceneScript.percentage = data.conpletion;
            _saveSceneScript.planetValue = data.planetValue;
            _saveSceneScript.playersChoice = data.playerChoice;
            Debug.Log("WTF");
        }
        else
        {
            _saveSceneScript.level = 0;
            _saveSceneScript.time = 0;
            _saveSceneScript.percentage = 0;
            _saveSceneScript.amountUntilNextLevel = 0;
            Debug.Log("Started");
        }
    }
    public void SetBool()
    {
        LoadScene = true;
    }
    public void Save()
    {
        Debug.Log("Saving...");
        time = _saveSceneScript.time;
        completion = _saveSceneScript.percentage;
        level = _saveSceneScript.level;
        levelAmountCompleted = _saveSceneScript.amountUntilNextLevel;
        
        SaveSystem.SaveMoney(_saveManager);
        
        // SaveSystem.SaveMoney(_saveManager);
    }
}
