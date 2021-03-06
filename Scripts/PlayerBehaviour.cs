using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	private bool scale = false;
	private float scaler = 0.9f;
	public float speed = 10;
	private Camera cam;
	private Vector2 offset, startState, startPosition;
	private Rigidbody2D rb;

	void Start() {
		cam = GameObject.Find ("Main Camera").GetComponent<Camera> ();
		startState = this.gameObject.transform.localScale;
		startPosition = this.gameObject.transform.position;
		rb = this.gameObject.GetComponent<Rigidbody2D> ();
	}

	void Update() {
		if (Input.GetMouseButtonDown (0)) {
			scale = !scale;
		}
		if (Input.GetMouseButtonDown (1)) {
			Reset ();
		}

		if (scale && this.gameObject.transform.localScale.x > startState.x/4) {
			this.gameObject.transform.localScale *= scaler;
		} else if (!scale && this.gameObject.transform.localScale.x < startState.x) {
			this.gameObject.transform.localScale /= scaler;
		}

		if (rb.velocity.magnitude > 5) {
			rb.velocity = (rb.velocity / rb.velocity.magnitude) * 2;
		}

	}

	void OnMouseOver() {

		offset = cam.ScreenToWorldPoint (Input.mousePosition);
		offset.x = offset.x - rb.position.x;
		offset.y = offset.y - rb.position.y;

		rb.AddForce (offset * -speed);
	}

	void OnMouseExit() {
	}

	public void Reset() {
		this.gameObject.transform.position = startPosition;
		rb.velocity += -rb.velocity;
	}

	public void Win() {
		cam.GetComponent<GameManager> ().isWin = true;
		Reset ();
	}
}
