using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {
	
	private Rigidbody2D rb2d;

	void Start() {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
