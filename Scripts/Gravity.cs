using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

	private bool Collision;
	private Rigidbody2D rb;
	// Update is called once per frame
	void Update () {

		rb = GetComponent<Rigidbody2D> ();
	}


	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "G Shift") {
			rb.gravityScale = -3;
		}
		if (other.tag == "G Return") {
			rb.gravityScale = 3;
		}
	}
}
