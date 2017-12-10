using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	//make min nad max global

	int max = 1000;
	int min = 1;
	int guess = 500; 

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me !");



		print("The highest number you can pick is " + max);
		print("the lowest number you can pick is " + min);

		print("Is the number higher  or lower than " + guess);
		print("Up = higher, down = lower , return = equal");

			
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed");		
			//set guess to min
			min = guess;
			//reset guess
			guess = (min + max)/2;
			print(guess, max);

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Up down pressed");	
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");	
		}
	}
}
