using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {


	public float Life_guage_Max = 100f;
	public float Current_life = 0f;

	/*public float Enemy_Life_Max = 50f;
	public float Enemy_Life_Cur = 0f;*/

	// Use this for initialization
	void Start () {
		Current_life = Life_guage_Max;
		//Enemy_Life_Cur = Enemy_Life_Max;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
