using UnityEngine;
using System.Collections;

public class StartExplain : MonoBehaviour {
	
	public static bool startTut = true;
	public static bool explainSpawned = false;
    public GUIText left;
    public GUIText right;
	public float sec;

    private bool leftBool = false;
    private bool rightBool = false;
    private bool leftarrow = false;


	void Update()
	{
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftBool = true;
            if(!leftarrow)
            {
                Destroy(GameObject.FindGameObjectWithTag("left"));
                Instantiate(right);
                leftarrow = true;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightBool = true;
        }

        if (leftBool && rightBool)
        {
            Application.LoadLevel(2);
        }

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
        Instantiate(left);
	}

}
