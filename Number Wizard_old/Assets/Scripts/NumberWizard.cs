﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me !");

		int max = 1000;
		int min = 1;

		print("the highes number you can pick is " + max );
		print("the highes number you can pick is " + min );

		print("Is the the number higher or lower than 500?");
		print("Up arrow = higher, down = lower, return = equal");

		print("Hi from VSCode");

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow pressed");
		}           

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow pressed");
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");

		}
	}
}
