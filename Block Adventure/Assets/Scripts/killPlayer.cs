using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour {

	public AudioSource death;

	void OnTriggerEnter(Collider other) {
		death.Play ();
		Destroy(other.gameObject);
		SceneManager.LoadScene ("loseMenu");
	}
}
