using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacelePlacing : MonoBehaviour {

    public Transform player;
    public Transform prefabs;
    public int rocks;

    private Vector2 minRange;
    private Transform[] prefabClones;
    private bool canSpawn;


    public void Update()
    {

        minRange = new Vector2(player.position.x + 30, Random.Range(1,3));
        prefabs.position = minRange;

        for(int i = 0; i < rocks; i++)
        {
            prefabClones[i] = Instantiate(prefabs) as Transform;
        }
       
    }
   
}
