using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCircleScript : MonoBehaviour {

	private PlayerBehaviour playerScript;
	private CircleCollider2D playerCollider;

	void Start () {
		playerScript = GameObject.Find ("Player").GetComponent<PlayerBehaviour>();
		playerCollider = playerScript.gameObject.GetComponent<CircleCollider2D>();
	}

	void Update () {
		if (gameObject.GetComponent<CircleCollider2D> ().IsTouching (playerCollider)) {
			playerScript.Win ();
		}
	}
}
