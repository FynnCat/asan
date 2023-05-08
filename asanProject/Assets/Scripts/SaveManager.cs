using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    string path;
    public bool LoadScene = false;

    // Start is called before the first frame update
    void Start()
    {
         
            PlayerData data = SaveSystem.LoadMoney();

        if (data != null)
        {
            _saveSceneScript.level = data.level;
            _saveSceneScript.time = data.time;
            _saveSceneScript.percentage = data.conpletion;
            _saveSceneScript.amountUntilNextLevel = data.levelAmountCompleted;
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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetBool()
    {
        LoadScene = true;
    }
    public void save(bool open)
    {
        time = _saveSceneScript.time;
        completion = _saveSceneScript.percentage;
        level = _saveSceneScript.level;
        levelAmountCompleted = _saveSceneScript.amountUntilNextLevel;

        // SaveSystem.SaveMoney(_saveManager);
    }
}
