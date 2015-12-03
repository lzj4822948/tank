using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float moveSpeed = 1f;
	public float rotateSpeed = 1f;
	private Shoot tw;
	// Use this for initialization
	void Start () {
		tw = GetComponent<Shoot> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal1");
		float vertical = Input.GetAxis("Vertical1");

		transform.Translate (Vector3.forward * vertical * moveSpeed * Time.deltaTime);
		transform.Rotate (Vector3.up * horizontal * rotateSpeed * Time.deltaTime);

//		if (Input.GetKey (KeyCode.W)) {
//			transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime);
//		}
//		if (Input.GetKey (KeyCode.S)) {
//			transform.Translate(new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime);		
//		}
//		if (Input.GetKey (KeyCode.A)) {
//			transform.Rotate(new Vector3(0, -1, 0) * rotateSpeed * Time.deltaTime);		
//		}
//		if (Input.GetKey (KeyCode.D)) {
//			transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed * Time.deltaTime);
//		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			tw.shoots();
		}
	}
}
