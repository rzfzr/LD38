using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Over : MonoBehaviour {


	public Text agricultureText, constructionText, societyText,totalText;

	void Start () {
		agricultureText.text = (Player.agriculture).ToString ();
		constructionText.text = (Player.construction).ToString ();
		societyText.text = (Player.society).ToString ();
		totalText.text = (Player.agriculture + Player.construction + Player.society).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void okClick(){

		UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
	}
}
