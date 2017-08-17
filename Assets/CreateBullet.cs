using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour {

	public GameObject Bullet;
	public GameObject Cam;

	public void Create () {
		Destroy (Instantiate (Bullet, Cam.transform.position, Cam.transform.rotation), 5f);
	}
}
