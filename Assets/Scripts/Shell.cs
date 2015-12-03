using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {
	public GameObject explosion;
	public float r;
	public float s;
	public float damage;

	void OnCollisionEnter(){
		GameObject explosionShow = Instantiate (explosion, transform.position, transform.rotation) as GameObject;
		Destroy (gameObject);
		Destroy (explosionShow, 1.5f);

		Collider[] cols = Physics.OverlapSphere (transform.position, r);
		for (int i = 0; i < cols.Length; ++i) {
			Rigidbody body = cols[i].GetComponent<Rigidbody>();
			if(body)
				body.AddExplosionForce(s,transform.position, r);

			Unit u = cols[i].GetComponent<Unit>();
			if(u){
				u.Damage(damage);
			}
		}
	}
}
