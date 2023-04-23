using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenManager : MonoBehaviour
{
    [SerializeField] Slider _oxygenSlider;
    public int _maxOxygen, _currentOxygen;
    // Start is called before the first frame update
    void Start()
    {
        _currentOxygen = _maxOxygen;
        _oxygenSlider.maxValue = _maxOxygen;
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
}
