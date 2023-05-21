using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    [SerializeField] OxygenManager _oxygenManager;
    // Start is called before the first frame update
    void Start()
    {
        _oxygenManager = GameObject.FindObjectOfType<OxygenManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
        Debug.Log("Enemy found!");
            _oxygenManager._currentOxygen -= 7;
        }
    }
}
