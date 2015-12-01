using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float moveSpeed = 1f;
	public float rotateSpeed = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime);		
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(new Vector3(0, -1, 0) * rotateSpeed * Time.deltaTime);		
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed * Time.deltaTime);
		}
	}
}
