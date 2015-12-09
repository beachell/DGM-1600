using UnityEngine;
using System.Collections;

public class DirectionChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public enum Changer{ Horizontal, Vertical};
	public Changer changer; 

	void OnCollisionEnter (Collision hit)
	{

		if (hit.transform.tag == "duck") 
		{
			DuckMovement movement = hit.gameObject.GetComponent<DuckMovement>();

			if(changer == Changer.Horizontal)
			{
				movement.DirectionChanger(new Vector3 (-1, 1, 0));
			}
		

			else if (changer == Changer.Vertical) 
			{
				movement.DirectionChanger(new Vector3(1, -1, 0));
			}

		}
	}

}