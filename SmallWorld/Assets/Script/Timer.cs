using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour {

	private bool finished = false;

	public Slider sliderTimer;

	private static float startTime;

	void Start () {
		
		sliderTimer.value = 0;
	}


	void Update () {

		sliderTimer.value += (Time.deltaTime * 0.02f);

		if (sliderTimer.value == 1)
			Finish ();

	}

	void Finish(){
	
		print ("end");

	}
}
