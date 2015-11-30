using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	public int killCount = 0;
	public GameObject captured_duck;
	 
		public void Spawn_captured_Duck()
	{
		Debug.Log("spawn caputered duck");
		Instantiate(captured_duck,transform.position, Quaternion.identity);
		
	}
	void OnTriggerEnter(Collider hit)
	{

		if (hit.tag == "killZone") 
		{
			int totalKills = killCount;

			Destroy(this.gameObject);
			totalKills ++;
			Debug.Log (totalKills);



		}
	}
}
