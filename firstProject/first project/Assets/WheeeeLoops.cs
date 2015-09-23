using UnityEngine;
using System.Collections;

public class WheeeeLoops : MonoBehaviour {

	// Use this for initialization
	int enemies = 4;

	bool shootTheGun = false;

	void Start () {
		//for
		for (int i = 0; i<enemies; i++) 
		{
			Debug.Log ("we made an enemy" +i);
		}
		//while
		while (enemies>0) 
		{
			Debug.Log("we killed an enemy sir");
			--enemies;
		}


		//do while
		do {
			Debug.Log ("I want to fire the gun sir");

		} while (shootTheGun == true);

		//foreach

		string[] strings = new string[4];
		
		strings[0] = "reload";
		strings[1] = "reload again";
		strings[2] = "didn't you hear me RELOAD!";
		strings[3] = "never mind Johnson, we're dead, you killed us Johnson";

		foreach (string item in strings) 
		{
			Debug.Log (item);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
