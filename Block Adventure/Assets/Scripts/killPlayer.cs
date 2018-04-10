using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour {

	public AudioSource death;

	void OnTriggerEnter(Collider other) {
		death.Play ();
		Destroy(other.gameObject);
	}
}
