using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    [SerializeField] int scanTime;
    public bool Branch_01 = false, Bush_01 = false, Bush_02 = false, Bush_03 = false, Flowers_01 = false, Flowers_02 = false, Grass_01 = false, Grass_02 = false, Mushroom_01 = false, Mushroom_02 = false, Rock_01 = false, Rock_02 = false, Rock_03 = false, Rock_04 = false, Rock_05 = false, Stump_01 = false, Tree_01 = false, Tree_02 = false, Tree_03 = false, Tree_04 = false, Tree_05 = false;
    [SerializeField] GameObject Branch_01Data, Bush_01Data, Bush_02Data, Bush_03Data, Flowers_01Data, Flowers_02Data, Grass_01Data, Grass_02Data, Mushroom_01Data, Mushroom_02Data, Rock_01Data, Rock_02Data, Rock_03Data, Rock_04Data, Rock_05Data, Stump_01Data, Tree_01Data, Tree_02Data, Tree_03Data, Tree_04Data, Tree_05Data;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Branch_01)
        {
            Branch_01Data.SetActive(true);
             
        }
        if (Bush_01)
        {
            Bush_01Data.SetActive(true);
        }
        if (Bush_02)
        {
            Bush_02Data.SetActive(true);
        }
        if (Bush_03)
        {
            Bush_03Data.SetActive(true);
        }
        if (Flowers_01)
        {
            Flowers_01Data.SetActive(true);
        }
        if (Flowers_02)
        {
            Flowers_02Data.SetActive(true);
        }
        if (Grass_01)
        {
            Grass_01Data.SetActive(true);
        }
        if (Grass_02)
        {
            Grass_02Data.SetActive(true);
        }
        if (Mushroom_01)
        {
            Mushroom_01Data.SetActive(true);
        }
        if (Mushroom_02)
        {
            Mushroom_02Data.SetActive(true);
        }
        if (Rock_01)
        {
            Rock_01Data.SetActive(true);
        }
        if (Rock_02)
        {
            Rock_02Data.SetActive(true);
        }
        if (Rock_03)
        {
            Rock_03Data.SetActive(true);
        }
        if (Rock_04)
        {
            Rock_04Data.SetActive(true);
        }
        if (Rock_05)
        {
            Rock_05Data.SetActive(true);
        }
        if (Stump_01)
        {
            Stump_01Data.SetActive(true);
        }
        if (Tree_01)
        {
            Tree_01Data.SetActive(true);
        }
        if (Tree_02)
        {
            Tree_02Data.SetActive(true);
        }
        if (Tree_03)
        {
            Tree_03Data.SetActive(true);
        }
        if (Tree_04)
        {
            Tree_04Data.SetActive(true);
        }
        if (Tree_05)
        {
            Tree_05Data.SetActive(true);
        }
    }

    public void OnScan()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
       // yield return new WaitForSeconds(scanTime);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "Branch_01")
            {
                Branch_01 = true;
            }
            if (hit.transform.tag == "Bush_01")
            {
                Bush_01 = true;
            }
            if (hit.transform.tag == "Bush_02")
            {
                Bush_02 = true;
            }
            if (hit.transform.tag == "Bush_03")
            {
                Bush_03 = true;
            }
            if (hit.transform.tag == "Flowers_01")
            {
                Flowers_01 = true;
            }
            if (hit.transform.tag == "Flowers_02")
            {
                Flowers_02 = true;
            }
            if (hit.transform.tag == "Grass_01")
            {
                Grass_01 = true;
            }
            if (hit.transform.tag == "Grass_02")
            {
                Grass_02 = true;
            }
            if (hit.transform.tag == "Mushroom_01")
            {
                Mushroom_01 = true;
            }
            if (hit.transform.tag == "Mushroom_02")
            {
                Mushroom_02 = true;
            }
            if (hit.transform.tag == "Rock_01")
            {
                Rock_01 = true;
            }
            if (hit.transform.tag == "Rock_02")
            {
                Rock_02 = true;
            }
            if (hit.transform.tag == "Rock_03")
            {
                Rock_03 = true;
            }
            if (hit.transform.tag == "Rock_04")
            {
                Rock_04 = true;
            }
            if (hit.transform.tag == "Rock_05")
            {
                Rock_05 = true;
            }
            if (hit.transform.tag == "Stump_01")
            {
                Stump_01 = true;
            }
            if (hit.transform.tag == "Tree_01")
            {
                Tree_01 = true;
            }
            if (hit.transform.tag == "Tree_02")
            {
                Tree_02 = true;
            }
            if (hit.transform.tag == "Tree_03")
            {
                Tree_03 = true;
            }
            if (hit.transform.tag == "Tree_04")
            {
                Tree_04 = true;
            }
            if (hit.transform.tag == "Tree_05")
            {
                Tree_05 = true;
            }
        }
    }
}