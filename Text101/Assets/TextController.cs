using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	//add a text variable of type text 
	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Hello World!"; 	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "You are in a prison cell and you want to escape. \n"+
						"There are some dirty sheets on the bed, \n"+
						"a mirror on the wall, \n"+
						"a door locked from the outside.\n\n" +
						"Press S to view sheets, M to view Mirror, and L to view Lock";
						

		}
	}
}
