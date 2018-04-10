using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour {

	private int score;
	public Text scoreText;
	public AudioSource pickup;



	// Use this for initialization
	void Start () {
		score = 0;
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("pickup")) {
			score++;
			scoreText.text = "Score : " + score;
			pickup.Play ();
		}

		if (other.gameObject.CompareTag ("goal")) {
			SceneManager.LoadScene ("Level01");
		}
	}
	

}
