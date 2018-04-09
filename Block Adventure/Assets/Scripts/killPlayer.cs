using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
