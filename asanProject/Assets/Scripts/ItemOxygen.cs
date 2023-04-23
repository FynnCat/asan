using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOxygen : MonoBehaviour
{
    [SerializeField] OxygenManager _oxygenManager;
    [SerializeField] int _oxygenAmount;
    [SerializeField] bool _addOxygen;
    // Start is called before the first frame update
    void Start()
    {
        _oxygenManager = GameObject.FindObjectOfType<OxygenManager>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (_addOxygen)
            {
                _oxygenManager._currentOxygen = _oxygenManager._currentOxygen + _oxygenAmount;
            }
            else if (!_addOxygen)
            {
                _oxygenManager._currentOxygen = _oxygenManager._currentOxygen - _oxygenAmount;
            }
        }
    }
}
