//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Unity.AI.Navigation;

public class RandomPlacement : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    public GameObject[] objects2;
    [SerializeField] Transform XLoc, YLoc;
    private GameObject objectToSpawn;
    //[SerializeField] private NavMeshSurface m_Surface;

    // Start is called before the first frame update
    void Start()
    {
        SecondPlacement();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void SecondPlacement()
    {
        Debug.Log("Hello");
        int num3 = Random.Range(35000, 35600);
        int num4 = 0;

        while (num4 < num3)
        {
            objectToSpawn = objects2[Random.Range(0, objects2.Length - 1)];
            float XPos = Random.Range(XLoc.position.x, XLoc.position.x + 1000);
            float ZPos = Random.Range(XLoc.position.z, XLoc.position.z + 1000);
            Instantiate(objectToSpawn, new Vector3(XPos, 0, ZPos), Quaternion.identity);
            num4++;
            
        }
        ThirdPlacement();
       // m_Surface.BuildNavMesh();
    }
    void ThirdPlacement()
    {
        Debug.Log("Hello");
        int num3 = Random.Range(700, 1600);
        int num4 = 0;

        while (num4 < num3)
        {
            objectToSpawn = objects[Random.Range(0, objects.Length - 1)];
            float XPos = Random.Range(XLoc.position.x, XLoc.position.x + 1000);
            float ZPos = Random.Range(XLoc.position.z, XLoc.position.z + 1000);
            Instantiate(objectToSpawn, new Vector3(XPos, 0, ZPos), Quaternion.identity);
            num4++;

        }
        // m_Surface.BuildNavMesh();
    }

}