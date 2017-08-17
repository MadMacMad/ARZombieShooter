using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour {

	private Animation animation;
	private bool shouldMove = false; 

	void Start () {
		animation = GetComponent <Animation> ();
	}

	void Update () {
		if (shouldMove) {
			transform.LookAt (Camera.main.transform);
			transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
			transform.Translate (Vector3.forward * Time.deltaTime * (transform.localScale.x * .03f));
		}
	}

	public void Walk () {
		if (!animation.isPlaying) {
			animation.Play ();
			shouldMove = true;
		} else {
			animation.Stop ();
			shouldMove = false;
		}
	}

	//public void Bigger () {
	//	transform.localScale += new Vector3 (1, 1, 1);
	//}

	//public void Smaller () {
	//	if (transform.localScale.x > 1) {
	//		transform.localScale -= new Vector3 (1, 1, 1);
	//	}
	//	transform.localScale -= new Vector3 (1, 1, 1);
	//}

	void OnTriggerEnter (Collider col)
	{
		//first disable the zombie's collider so multiple collisions cannot occur
		GetComponent<CapsuleCollider>().enabled = false;
		//destroy the bullet
		Destroy(col.gameObject);
		//stop the zombie from moving forward
		shouldMove = false;
		//stop the walking animation and play the falling back animation
		animation.Stop ();
		animation.Play ("Death");
		//destroy this zombie in six seconds.
		Destroy (gameObject, 6);
		}
		
}

