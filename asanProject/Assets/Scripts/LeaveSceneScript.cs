using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaveSceneScript : MonoBehaviour
{
    [SerializeField] saveSceneScript _saveSceneScript;
    [SerializeField] TextMeshProUGUI _percentageText;
    [SerializeField] Slider _percentageSlider, _resultSlider, _estimateSlider;
    [SerializeField] TextMeshProUGUI _timeText;
    [SerializeField] int _time, _level;
    [SerializeField] TextMeshProUGUI _levelText;
    [SerializeField] ExitGamePlay _exitGamePlay;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _percentageSlider.minValue = 0;
        _percentageSlider.maxValue = 100;
        _percentageSlider.value = _saveSceneScript.percentage;
        _percentageText.text = (int)_saveSceneScript.percentage + " %";


        //Time.
        _time = (int)_saveSceneScript.time;
        int minutes = Mathf.FloorToInt(_time / 60f);
        int seconds = Mathf.FloorToInt(_time % 60f);

        _timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        //Level.
        _level = _saveSceneScript.level;
        _levelText.text = "lvl" + _level;

        //Results slider.
        _estimateSlider.minValue = -100;
        _estimateSlider.maxValue = 100;
        _estimateSlider.value = _saveSceneScript.playersChoice;
        //Results slider.
        _resultSlider.minValue = -100;
        _resultSlider.maxValue = 100;
        _resultSlider.value = _saveSceneScript.planetValue;
    }
}
