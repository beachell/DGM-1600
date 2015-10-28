using UnityEngine;
using System.Collections;

public class ClassesAndData : MonoBehaviour {

/*	public class Spells
	{
		public int fire;

		public Spells (int _f)
		{
			fire = _f;
		}

		public Spells ()
		{
			fire = 2;
		}
	}



	//public Spells mySpells = new Spells(3);
	//public Spells mySpells2 = mySpells;

	public Spells mySpells = new Spells(3);

	public int num;

	// Use this for initialization
	void Start () {
		Debug.Log (mySpells.fire);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}*/
	public class Cannon
	{
	public int ammo;

		public Cannon (int shots)
		{
			ammo = shots;
		}

		public Cannon ()
		{
			ammo = 4;
		}

	}

	public Cannon myCannon = new Cannon(5);

	void Start()
	{
		Debug.Log (myCannon.ammo);
		/*
		int num1 = 5;
		int num2 = num1;
		num2 = 10;

		Cannon myCannon = new Cannon(8);
		Cannon cannon2 = myCannon;
		cannon2.ammo = 100;
*/
	}


}