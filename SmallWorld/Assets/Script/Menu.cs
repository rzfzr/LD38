using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	
	public void PlayClick(){

		UnityEngine.SceneManagement.SceneManager.LoadScene("Play");
	}
}
