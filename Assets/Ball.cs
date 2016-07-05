using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private bool isStarted;
	private Rigidbody rigidBody;
	private Vector3 initialPosition;
	private const float velocityZ = 6f;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		initialPosition = rigidBody.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isStarted && Input.GetKey(KeyCode.Space)) {
			isStarted = true;

			var velocity = new Vector3 (Random.Range (-4, 4), 0, velocityZ);
			rigidBody.velocity = velocity;
		}
	}

	void OnCollisionEnter(Collision collision) {
		var name = collision.gameObject.name;

		switch (name) {
		case "BorderLeft":
		case "BorderRight":
			Reset ();
			break;
		}
	}

	private void Reset() {
		rigidBody.transform.position = initialPosition;
		rigidBody.velocity = Vector3.zero;
		isStarted = false;
	}
}
