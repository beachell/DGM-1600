using UnityEngine;
using System.Collections;

public class ArrayScript : MonoBehaviour {

	public string[] arrayName = new string[8];
	public string[] arrayName2 = {"yay", "i'm a second line"};
	// Use this for initialization
	void Start () {
			

		
		arrayName[0]= "count down"; 
		arrayName[1]= "7"; 
		arrayName[2]= "6"; 
		arrayName[3]= "5"; 
		arrayName[4]="4" ; 
		arrayName[5]="3" ; 
		arrayName[6]= "Boom"; 
		arrayName[7]="guess the fuze was shorter than we thought." ; 


		for(int i=0;i<arrayName.Length; i++)
		{

			Debug.Log(arrayName[i]);

			
		}
		Debug.Log(arrayName2[0]);
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
