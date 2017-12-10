﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	//make min nad max global
	int max = 1000;
	int min = 1;
	int guess = 500; 

	// Use this for initialization
	void Start () {
		StartGame ();

			
	}
	void StartGame(){
		//fix the rounding problem to retun max
		max = max + 1;
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
			//set guess to min
			min = guess;
			NextGuess();

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();

		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");	
		}
	}

	
	void NextGuess(){
		guess = (min + max)/2;
		print("Higher or lower that " + guess);
		print("Up = higher, down = lower , return = equal");
	}
}
