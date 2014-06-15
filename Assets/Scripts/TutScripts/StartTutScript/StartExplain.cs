using UnityEngine;
using System.Collections;

public class StartExplain : MonoBehaviour {
	
	public static bool startTut = true;
	public static bool explainSpawned = false;
	public float sec;


	void Update()
	{
		if(startTut)
		{
			Destroy(GameObject.FindWithTag("Text"));
			CreateExplainLevel();
			explainSpawned = true;
			startTut = false;
			FadeScript.fadeBool = true;

		}
	}

	void CreateExplainLevel()
	{
		Instantiate(Resources.Load("TutPrefabs/TutExplain"),new Vector3(0,0,0),Quaternion.identity);
	}
}
