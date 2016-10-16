using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - Player.transform.position;
	}

	// LateUpdate is called once aftar all update for per frame
	void LateUpdate () {
		transform.position = Player.transform.position + offset;
	}
}
