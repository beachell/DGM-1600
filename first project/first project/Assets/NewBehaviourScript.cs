using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	int myInt = 22;
	// Use this for initialization
	void Start () {
		

		Debug.Log (myInt);
	}

	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
	
	// Update is called once per frame
	void Update () {

		//changes the color of the cube when r key is pressed.
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			myInt = MultiplyByTwo(myInt);
		}


	}
}
