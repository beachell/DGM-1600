 using UnityEngine;
using System.Collections;

public class pass_off_script : MonoBehaviour {

	int numberCreated = 55;

	// Use this for initialization
	void Start () {
		numberCreated = MultiplyThisNumber(numberCreated);
		Debug.Log(numberCreated); 
	
	
	}
	int MultiplyThisNumber(int numberCreated)
	{
		int ret;
		ret = numberCreated *4;
		return ret;
	}
	// Update is called once per frame
	void Update () {
	
	}


}
