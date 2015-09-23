using UnityEngine;
using System.Collections;

public class LoopsScritps : MonoBehaviour {

	int enemies = 12;
	// Use this for initialization
	void Start () {
		///*  for loop.
		for (int i =0;i< enemies;i++)
		{
			Debug.Log("creating enemy:"+ i);

		}
		//*/ 
		///*while loop
		while (enemies > 0)
		{
			Debug.Log ("We took out an enemy");
				enemies--;
		}
		//*/
		//do while
		bool shouldWeFire = false;

		do 
		{
			print("FIRE");
		}while (shouldWeFire== true);

		//for each
		string[] strings = new string[4];

		strings[0] = "reload";
		strings[1] = "reload again";
		strings[2] = "didn't you hear me RELOAD!";
		strings[3] = "never mind Johnson, we're dead, you killed us Johnson";

		foreach (string item in strings)
		{
			print (item);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
