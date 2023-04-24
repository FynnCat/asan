//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Unity.AI.Navigation;

public class RandomPlacement : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    [SerializeField] GameObject[] objects2;
    [SerializeField] Transform XLoc, YLoc;
    private GameObject objectToSpawn;
    [SerializeField] private NavMeshSurface m_Surface;

    // Start is called before the first frame update
    void Start()
    {
       /* int num = 1;
        int num2 = 0;

        while (num2 < num)
        {
            objectToSpawn = objects[Random.Range(0, objects.Length - 1)];
            float XPos = Random.Range(XLoc.position.x, XLoc.position.x + 10);
            float ZPos = Random.Range(XLoc.position.z, XLoc.position.z + 10);
            Instantiate(objectToSpawn, new Vector3(XPos, 0, ZPos), Quaternion.identity);
            num2++;
        }*/
        SecondPlacement();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void SecondPlacement()
    {
        Debug.Log("Hello");
        int num3 = Random.Range(4, 20);
        int num4 = 0;

        while (num4 < num3)
        {
            objectToSpawn = objects2[Random.Range(0, objects2.Length - 1)];
            float XPos = Random.Range(XLoc.position.x, XLoc.position.x + 10);
            float ZPos = Random.Range(XLoc.position.z, XLoc.position.z + 10);
            Instantiate(objectToSpawn, new Vector3(XPos, 10, ZPos), Quaternion.identity);
            num4++;
            
        }
        m_Surface.BuildNavMesh();
    }

}