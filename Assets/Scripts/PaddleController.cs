using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float moveSpeed;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector2 movement = new Vector2 (moveHorizontal, 0);
		rb2d.velocity = (movement * moveSpeed * Time.deltaTime);
	}

}
