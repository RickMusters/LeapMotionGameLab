using UnityEngine;
using System.Collections;

public class CameraBounds : MonoBehaviour 
{
	public Transform player;

	public Vector2
		margin,
		smoothing;

	public BoxCollider2D cameraBounds;

	private Vector3
		_min,
		_max;

	public bool isFollowing { get; set; }

	public void Start()
	{
		_min = cameraBounds.bounds.min;
		_max = cameraBounds.bounds.max;
		isFollowing = true;
	}

	public void Update()
	{
		var x = transform.position.x;
		var y = transform.position.y;

		if(isFollowing)
		{
			if(Mathf.Abs(x - player.position.x) > margin.x)
			{
				x = Mathf.Lerp(x, player.position.x, smoothing.x * Time.deltaTime);
			}
			if(Mathf.Abs(y- player.position.y) > margin.y)
			{
				y = Mathf.Lerp(y, player.position.y, smoothing.y * Time.deltaTime);
			}

			var cameraHalfWidth = camera.orthographicSize * ((float) Screen.width/Screen.height);

			x = Mathf.Clamp(x,_min.x + cameraHalfWidth, _max.x - cameraHalfWidth);
			y = Mathf.Clamp(y, _min.y + camera.orthographicSize, _max.y - camera.orthographicSize);

			transform.position = new Vector3(x,y, transform.position.z);


		}
	}


}
