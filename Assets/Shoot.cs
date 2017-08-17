using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject Gun;
	public GameObject Trigger;
	public GameObject Bullet;
	public GameObject SpawnPoint;

	public void Start () {
		Destroy (Instantiate (Bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation), 5f);
		Gun.GetComponent<AudioSource>().Play ();
		Gun.GetComponent<Animation>().Play ();
		Trigger.GetComponent<Animation>().Play ();
	}
}
