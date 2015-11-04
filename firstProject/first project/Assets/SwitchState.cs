using UnityEngine;
using System.Collections;

public class SwitchState : MonoBehaviour {

	public int gameDifficulty = 4;

	void ChooseYourPain ()
	{
		switch (gameDifficulty)
		{
		case 2:
			print ("why is this so hard");
			break;
		case 1:
			print ("this is normal");
			break;

		default:
				print ("this is easy as pie");
			break;

		}
	}
	void Start()
	{
	}
	void Update()
	{
		ChooseYourPain();
	}
}

