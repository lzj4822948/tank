using UnityEngine;
using System.Collections;

public class Shoot: MonoBehaviour {
	public GameObject shoot;
	public Transform obj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		if (Input.GetKey (KeyCode.Space)) {
			shoots();
		}
	}

	void shoots (){
		Instantiate(shoot, obj.position, obj.rotation);
	}
}
