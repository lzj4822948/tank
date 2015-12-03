using UnityEngine;
using System.Collections;

public class Shoot: Unit {
	public GameObject shoot;
	public Transform obj;
	public float speed = 100f;
	
	private AudioSource bombAudio;

	// Use this for initialization
	void Start () {
		bombAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void shoots (){
		GameObject bullet = Instantiate(shoot, obj.position, obj.rotation) as GameObject;
		Rigidbody r = bullet.GetComponent<Rigidbody> ();
		r.velocity = bullet.transform.forward * speed;
		bombAudio.Play ();
	}
}
