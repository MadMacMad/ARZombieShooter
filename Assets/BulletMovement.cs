using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	private float speed = 50f;

	void FixedUpdate () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}

}
