using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	int dishsInTheSink = 3;
	// Use this for initialization
	void Start () {
	
		while (dishsInTheSink > 0) {
			Debug.Log ("Another dish bites the dust");
			dishsInTheSink--;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
