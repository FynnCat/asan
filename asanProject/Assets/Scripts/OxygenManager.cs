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
    [SerializeField] Text _fillText;
    [SerializeField] int _refills;
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
        if (_currentOxygen <= 0)
        {
            SceneManager.LoadScene(0);
        }
        if (_enterEnemies.entered)
        {
            _fillText.text = "Press 'F' to fill body oxygen tank.";
        }
        else
            _fillText.text = "fill body oxygen tank.";


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
