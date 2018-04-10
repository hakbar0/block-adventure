using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene ("Main");
	}
}
