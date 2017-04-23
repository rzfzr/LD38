using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {

	public int i;
	// Use this for initialization
	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if (i < 100) {
			transform.Rotate (0, 0, 30 * Time.deltaTime);
		}else if(i<300){
			transform.Rotate (0, 0, -60 * Time.deltaTime);	
		} else {
			i = 0;
		}
		i++;
	}
}
