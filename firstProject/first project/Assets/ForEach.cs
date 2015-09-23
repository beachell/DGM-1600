using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] strings = new string[4];
		strings[0] ="First String";
		strings[1] ="Second String";
		strings[2] ="Third String";
		strings[3] ="Fourth String";

		foreach (string item in strings)
		{
			print (item);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
