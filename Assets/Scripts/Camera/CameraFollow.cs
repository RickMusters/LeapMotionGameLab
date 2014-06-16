using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float offsetY;
    public Transform player;

	void Update () {
        transform.position = new Vector3(player.position.x, player.position.y + offsetY, -10);
	}
}
