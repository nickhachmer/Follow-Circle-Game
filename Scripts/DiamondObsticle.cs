using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondObsticle : MonoBehaviour {

	public bool verticle;
	public float distance;
	public float startPosition;
	public float speed = 0.1f;

	private float counter;
	private PlayerBehaviour playerScript;
	private CircleCollider2D playerCollider;
	private Vector2 distanceVector;


	// Use this for initialization
	void Start () {
		playerScript = GameObject.Find ("Player").GetComponent<PlayerBehaviour>();
		playerCollider = playerScript.gameObject.GetComponent<CircleCollider2D>();
		counter = startPosition;

	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<BoxCollider2D> ().IsTouching (playerCollider)) {
			playerScript.Reset ();
		}

		if (verticle) {


			if (counter < distance) {
				gameObject.transform.position = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y + speed);
				counter += speed;
				if (counter > distance) {
					counter = distance;
				}
			} else if (counter < (2 * distance)) {
				gameObject.transform.position = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y - speed);
				counter += speed;		
			} else {
				counter -= 2 * distance;
			}
		} else {
			if (counter < distance) {
				gameObject.transform.position = new Vector2 (gameObject.transform.position.x + speed, gameObject.transform.position.y);
				counter += speed;
				if (counter > distance) {
					counter = distance;
				}
			} else if (counter < 2 * distance) {
				gameObject.transform.position = new Vector2 (gameObject.transform.position.x - speed, gameObject.transform.position.y);
				counter += speed;
			} else {
				counter -= 2 * distance;
			}
		}

	}



	void FixedUpdate() {
		

	}

}
