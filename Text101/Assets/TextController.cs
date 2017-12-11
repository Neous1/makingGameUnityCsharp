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
			text.text = "Lorem ipsum dolor sit amet consectetur adipiscing elit praesent himenaeos, " +
						"pharetra a eros enim euismod maecenas integer. Penatibus dis vel magna semper " +
						"montes consequat posuere et eu per, viverra libero vivamus rhoncus porta fringilla " +
						"cum auctor scelerisque tellus vehicula, platea rutrum torquent nam cursus leo tempus " +
						"curae neque. Curae dapibus libero magnis ultrices risus euismod leo donec, non lobortis " +
						"sapien pharetra cum ornare cras fames, tempus torquent potenti sollicitudin lectus habitant taciti.";
		}
	}
}
