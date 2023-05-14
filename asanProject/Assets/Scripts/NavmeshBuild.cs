using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class NavmeshBuild : MonoBehaviour
{
   [SerializeField] private NavMeshSurface m_Surface;
    // Start is called before the first frame update
    void Start()
    {
        m_Surface = GetComponent<NavMeshSurface>();
        m_Surface.BuildNavMesh();
        //StartCoroutine(WaitTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2);
        m_Surface.BuildNavMesh();
    }
}
