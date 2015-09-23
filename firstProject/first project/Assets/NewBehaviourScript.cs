using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	//creates an interger and is valued at 22
	int myInt = 22;
	// Use this for initialization
	void Start () {
		//calls the MultiplyByTwo function
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt);
	}
	//when called it will take the int number and then mulitply by 2 and return the value.
	int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
	
	// Update is called once per frame
	void Update () {

		//changes the color of the cube when r key is pressed.
	/*	if (Input.GetKeyDown (KeyCode.R)) 
		{
			gameObject.GetComponent<Renderer>().material.color = Color.red;
			//I would like it to call the multiplyByTwo function when the r button is pressed, but is not working
			 
		}
*/

	}
}


