using UnityEngine;
using System.Collections;

public class TankCam : MonoBehaviour {
	public Transform tank;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = tank.position;
	}
}
