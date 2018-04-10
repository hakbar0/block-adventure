using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(firstScene());
	}

	IEnumerator  firstScene(){
		yield return new WaitForSeconds(7);
		SceneManager.LoadScene("StartMenu");
	}
}
