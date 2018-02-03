using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public float speed;
	public Vector2 moveDirection;
	private Rigidbody2D rb2d;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();

		// Remove later
		moveDirection.Set(1,-1);
	}

	void Update () {
		rb2d.position += moveDirection * speed * Time.deltaTime;
	}
}
