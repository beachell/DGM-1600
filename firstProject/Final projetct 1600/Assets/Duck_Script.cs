using UnityEngine;
using System.Collections;

public class Duck_Script : MonoBehaviour {
	public GameObject Duck;
	// Use this for initialization
	/*void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/
	public void SpawnDuck()
	{
	Debug.Log("spawn duck");
		Instantiate(Duck,transform.position, Quaternion.identity);

	}

}
