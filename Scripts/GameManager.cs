using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool isWin = false;
	private static int counter = 1;

	void Start () {
	}

	void Update () {
		if (isWin && counter < 8) {
			isWin = false;
			counter += 1;
			SceneManager.LoadScene ("Scene" + counter);
			Debug.Log (counter);
		}
	}

	void FixedUpdate() {
		
	}
}
