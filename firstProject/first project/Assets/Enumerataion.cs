using UnityEngine;
using System.Collections;

public class Enumerataion : MonoBehaviour {


	enum LifeLevels:  {jaune , pyrah , nora , ren }; 

	// Use this for initialization
	void Start () {
		LifeLevels myLifeLevels;

		myLifeLevels = LifeLevels.nora;

		MatchLevels(myLifeLevels);
	}

	LifeLevels MatchLevels (LifeLevels life)
	{
		if (life == LifeLevels.jaune) {
			life = LifeLevels.pyrah;
			Debug.Log (life);
		} else if (life == LifeLevels.pyrah) {
			life = LifeLevels.jaune;
			Debug.Log (life);
		} else if (life == LifeLevels.nora) {
			life = LifeLevels.ren;
			Debug.Log (life);
		}
		else if(life== LifeLevels.ren){
			life = LifeLevels.nora;
		}
		Debug.Log (life);
		return life;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

//basicly used to show the opposit of the other. 