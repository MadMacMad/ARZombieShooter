using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	public GameObject col;

	void onTriggerEnter (Collider zombie) {
		if (zombie.tag == "z@walk") {
			Destroy(Instantiate(col, transform.position, transform.rotation), 0.98f);
			Destroy(gameObject);
		}
	} 
}
