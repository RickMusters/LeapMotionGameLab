using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelPlacer : MonoBehaviour {
    public Transform prefab;
    public int numberOfGrounds;
    public float recycleOffset;
    public Vector2 startPosition;

    private Vector2 nextPosition;
    private Queue<Transform> objectQueue; 

    void Start()
    {
        objectQueue = new Queue<Transform>(numberOfGrounds);
        for (int i = 0; i < numberOfGrounds; i++)
        {
            objectQueue.Enqueue((Transform)Instantiate(prefab));
        }
        nextPosition = startPosition;
        for (int i = 0; i < numberOfGrounds; i++)
        {
            Recycle();
        }

    }

    void Update()
    {
        if (objectQueue.Peek().localPosition.x + recycleOffset < Runner.distanceTraveled)
        {
            Recycle();
        }
    }

    private void Recycle()
    {
        Transform o = objectQueue.Dequeue();
        o.localPosition = nextPosition;
        nextPosition.x += o.localScale.x;
        objectQueue.Enqueue(o);
    }
}
