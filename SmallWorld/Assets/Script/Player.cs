using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed = 5,turnSpeed=5;

	private Vector3 moveDir;
	private Quaternion moveRot;

	
	void Update () {

		moveDir = new Vector3 (0, 0, Input.GetAxisRaw ("Vertical")).normalized;
//		moveRot = new Quaternion (Input.GetAxisRaw ("Horizontal"));
	}
	void FixedUpdate(){
		float speed = Input.GetAxisRaw("Horizontal") *turnSpeed* Time.deltaTime;
		transform.Rotate(0, speed, 0);
		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody>().position + GetComponent<Rigidbody>().transform.TransformDirection (moveDir) * moveSpeed * Time.deltaTime);
	}
}
