using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	//add a text variable of type text 
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		text.text = "Hello World!"; 	

	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.Space)) {
//
//						
//
//		}
	}
	void State_cell(){
		text.text = "You are in a prison cell and you want to escape. \n"+
			"There are some dirty sheets on the bed, \n"+
				"a mirror on the wall, \n"+
				"a door locked from the outside.\n\n" +
				"Press S to view sheets, M to view Mirror, and L to view Lock";
	}
}
