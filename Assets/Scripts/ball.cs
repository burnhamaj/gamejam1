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

	void OnTriggerEnter2D(Collider2D other) {

		System.Console.WriteLine("Collision!");

		// contactPoints.point  // This it the point of impact
		// contactPoints.normal // This is the vector perpendicular to the impact

		// First, find out the difference in our positions
		Vector2 diff = other.offset;//rb2d.position - other.offset;

		if (Mathf.Abs (diff.x) > Mathf.Abs (diff.y)) {
			// The x component is more significant
			moveDirection.x *= -1;
		} else {
			moveDirection.y *= -1;
		}

	}
}
