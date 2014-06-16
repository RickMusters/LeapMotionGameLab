using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstaclePlacer : MonoBehaviour
{
    public GameObject prefab;

    private GameObject curChunk;
    private GameObject prevChunk;

    void SpawnChunck()
    {
       /* prevChunk = curChunk;
        curChunk = Instantiate(prefab);
        curChunk.SetActive = false;

        if (Vector3.Distance(curChunk, prevChunk) > 1)
        {

        }
        else 
        {
            return;
        }*/
    }

}
