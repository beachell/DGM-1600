using UnityEngine;
using System.Collections;




public class IfStatements : MonoBehaviour {

	float coffeeTemperature = 85.0f;
	float hotLimitTemperature = 70f;
	//float coldLimitTemperature = 30f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{

		/*if (Input.GetKeyDown("a") ) 
		{
			Debug.Log ("you pressed the A button");
		}*/

		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();
		coffeeTemperature -= Time.deltaTime * 5f; 
	}
	void TemperatureTest ()
	{
		if (coffeeTemperature > hotLimitTemperature) {
			print ("Coffee is too hot.");
		} else if (coffeeTemperature < hotLimitTemperature) {
			print ("coffee is just right");
		} else {
			print ("coffee is frozen");
		}

		 
	}
}
