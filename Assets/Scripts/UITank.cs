using UnityEngine;
using System.Collections;

public class UITank : Unit {
	public float moveSpeed;
	public float kDistance;
	public Transform player;

	private Shoot tw;
	private float shootRate = 0;
	// Use this for initialization
	void Awake () {
		tw = GetComponent<Shoot> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!player)
			return;

		shootRate += Time.fixedDeltaTime; 

		float distance = Vector3.Distance (player.position, transform.position);
		if(distance > kDistance)
			transform.Translate (Vector3.forward * moveSpeed * Time.fixedDeltaTime);

		transform.LookAt (player.position);

		if (shootRate > 1f) {
			tw.shoots ();
			shootRate = 0;
		}
	}
}
