using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneGeneration : MonoBehaviour
{
    public GameObject plane;
    public GameObject player;
    private int _radius = 5;
    private int _planeoffset = 10;

    private Vector3 _startpos = Vector3.zero;
    private int _XPlayerMove => (int)(player.transform.position.x - _startpos.x);
    private int _ZPlayerMove => (int)(player.transform.position.z - _startpos.z);
    private int _XPlayerLocation => (int)(player.transform.position.x / _planeoffset) * _planeoffset;
    private int _ZPlayerLocation => (int)(player.transform.position.z / _planeoffset) * _planeoffset;

    private Hashtable _tilePlane = new Hashtable();
    // Update is called once per frame
    void Update()
    {
        if (_startpos == Vector3.zero)
        {
            for(int x = -_radius; x < _radius; x++)
            {
                for(int z = -_radius; z < _radius; z++)
                {
                    Vector3 pos = new Vector3((x * _planeoffset + _XPlayerLocation), 0, (z * _planeoffset + _ZPlayerLocation));
                    if (!_tilePlane.Contains(pos))
                    {
                        GameObject _plane = Instantiate(plane, pos, Quaternion.identity);
                        _tilePlane.Add(pos, _plane);
                    }
                }
            }
        }
        if (hasPlayerMoved())
        {
            for (int x = -_radius; x < _radius; x++)
            {
                for (int z = -_radius; z < _radius; z++)
                {
                    Vector3 pos = new Vector3((x * _planeoffset + _XPlayerLocation), 0, (z * _planeoffset + _ZPlayerLocation));
                    if (!_tilePlane.Contains(pos))
                    {
                        GameObject _plane = Instantiate(plane, pos, Quaternion.identity);
                        _tilePlane.Add(pos, _plane);
                    }
                }
            }
        }
    }

    bool hasPlayerMoved()
    {
        if (Mathf.Abs(_XPlayerMove) >= _planeoffset || Mathf.Abs(_ZPlayerMove) >= _planeoffset)
        {
            return true;
        }
        return false;
    }
}
