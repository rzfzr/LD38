using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float moveSpeed = 5;
	private Vector3 moveDir;


	
	void Update () {

		moveDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized;
	}
	void FixedUpdate(){
		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody>().position + GetComponent<Rigidbody>().transform.TransformDirection (moveDir) * moveSpeed * Time.deltaTime);
	}
}
