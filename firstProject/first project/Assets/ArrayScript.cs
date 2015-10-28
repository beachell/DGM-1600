using UnityEngine;
using System.Collections;

public class ArrayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
			
		string[] arrayName = new string[8];
		
		arrayName[0]= "count down"; 
		arrayName[1]= "7"; 
		arrayName[2]= "6"; 
		arrayName[3]= "5"; 
		arrayName[4]="4" ; 
		arrayName[5]="3" ; 
		arrayName[6]= "Boom"; 
		arrayName[7]="guess the fuze was short" ; 


		for(int i=0;i<arrayName.Length; i++)
		{

			Debug.Log(arrayName[i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
