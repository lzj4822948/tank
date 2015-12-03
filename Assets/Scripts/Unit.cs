using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

	public float health = 100f;
	public GameObject dead;

	public void Damage(float hurt){
		if (health <= 0) {
			Dead();
			return;
		}
		health -= hurt;
		if(health <= 0){
			Dead();
		}
	}

	void Dead(){
		Instantiate (dead, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
