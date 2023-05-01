using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenManager : MonoBehaviour
{
    public int timeBetweenOxygen;
    [SerializeField] Slider _oxygenSlider;
    public int _maxOxygen, _currentOxygen;
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
    }

    public void FillOxygen()
    {
        _oxygenSlider.value = _maxOxygen;
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(timeBetweenOxygen);
        _currentOxygen = _currentOxygen - 5;
        StartCoroutine(WaitTime());
    }
}
