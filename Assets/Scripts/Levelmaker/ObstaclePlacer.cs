using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstaclePlacer : MonoBehaviour
{

    public Transform player;
    public Transform prefab;
    public int numberOfObstacles;
    public float recycleOffset;
    public Vector2 startPosition;

    private Vector2 nextPosition;
    private Transform[] obstacleArray;

}
