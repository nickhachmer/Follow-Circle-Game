using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleObsticle : MonoBehaviour {

	private PlayerBehaviour playerScript;
	private CircleCollider2D playerCollider;

	// Use this for initialization
	void Start () {
		playerScript = GameObject.Find ("Player").GetComponent<PlayerBehaviour>();
		playerCollider = playerScript.gameObject.GetComponent<CircleCollider2D>();
	}

	void Update () {
		if (gameObject.GetComponent<CircleCollider2D> ().IsTouching (playerCollider)) {
			playerScript.Reset ();
		}
	}
}
