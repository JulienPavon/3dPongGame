using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public enum Player {
		Player1,
		Player2
	}

	public Player player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		switch (player) {
		case Player.Player1:
			if (Input.GetKey (KeyCode.A)) {
				if (CanMoveUp ()) {
					MoveUp ();
				}
			}
			if (Input.GetKey (KeyCode.Q)) {
				if (CanMoveDown ()) {
					MoveDown ();
				}
			}
			break;
		case Player.Player2:
			if (Input.GetKey (KeyCode.UpArrow)) {
				if (CanMoveUp ()) {
					MoveUp ();
				}
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				if (CanMoveDown ()) {
					MoveDown ();
				}
			}
			break;
		}
	}

	private bool CanMoveUp () {
		return transform.position.x < 5;
	}

	private bool CanMoveDown () {
		return transform.position.x > -5;
	}

	private void MoveUp() {
		transform.Translate (new Vector3 (0.3f, 0, 0));
	}

	private void MoveDown() {
		transform.Translate (new Vector3 (-0.3f, 0, 0));
	}
}
