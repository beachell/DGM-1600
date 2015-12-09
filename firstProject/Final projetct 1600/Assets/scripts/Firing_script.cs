using UnityEngine;
using System.Collections;

public class Firing_script : MonoBehaviour {


	public float Time_delay = 1f;


	public int Score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () 
	{
		Debug.Log (Score);
		//Rigidbody.useGravity = true ;
		Destroy (gameObject, Time_delay);

		Score = Score+10;


	}
}
