using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaEnemy : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] float _speed;
    [SerializeField] bool _debugBool;
    [SerializeField] TriggerEnterEnemies _triggerEnter;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(WaitTime());
    }

    // Update is called once per frame
    void Update()
    {
        
        //if ((_player.transform.position.x - transform.position.x) < 0.5f || (_player.transform.position.z - transform.position.z) < 0.5f && (_player.transform.position.z - transform.position.z) > -0.01 && (_player.transform.position.x - transform.position.x) > -0.01)
        
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(_speed);
        if (_triggerEnter.entered)
        {
            Debug.Log((_player.transform.position.x - transform.position.x));
            _debugBool = true;
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed);
        }
        else
        {
            _debugBool = false;
        }
        StartCoroutine(WaitTime());
    }
}
