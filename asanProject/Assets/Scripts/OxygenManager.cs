using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenManager : MonoBehaviour
{
    public int timeBetweenOxygen;
    [SerializeField] Slider _oxygenSlider;
    public int _maxOxygen, _currentOxygen;
    [SerializeField] TriggerEnterEnemies _enterEnemies;
    [SerializeField] Text _fillText, _endExplorationText;
    [SerializeField] int _refills;
    [SerializeField] ExitGamePlay _exitGamePlay;
    [SerializeField] Image _oxygenFill;
    [SerializeField] AudioSource _oxygenAlert;
    bool _playedOxygenLow = false;
    // Start is called before the first frame update
    void Start()
    {
        _currentOxygen = _maxOxygen;
        _oxygenSlider.maxValue = _maxOxygen;
        StartCoroutine(WaitTime());
    }

    // Update is called once per frame
    void Update()
    {
        
        _oxygenSlider.value = _currentOxygen;
        if (_currentOxygen <= 40)
        {
            _oxygenFill.color = Color.red;
            
            if(_playedOxygenLow == false)
            {
            _oxygenAlert.Play();
                _playedOxygenLow = true;
            }
        }
        if (_currentOxygen <= 0)
        {
            _exitGamePlay.SaveSelection();
            SceneManager.LoadScene("DeathScene");
        }
        if (_enterEnemies.entered)
        {
            _fillText.text = "Press 'F' to fill body oxygen tank.";
        }
        else
        {
            _fillText.text = "fill body oxygen tank.";
 
        }
        if (_enterEnemies.entered)
        { 
            _endExplorationText.text = "Press 'E' end exploration of this planet.";
        }
        else
        {
         
            _endExplorationText.text = "End exploration.";
        }

    }

    public void FillOxygen()
    {
        if (_enterEnemies.entered && _refills != 9)
        {
            _currentOxygen = _maxOxygen;
            _refills++;
        }
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(timeBetweenOxygen);
        _currentOxygen = _currentOxygen - 3;
        StartCoroutine(WaitTime());
    }
}
