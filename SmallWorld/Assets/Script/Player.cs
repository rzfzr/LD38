using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Player : MonoBehaviour {

	public float moveSpeed = 5,turnSpeed=5;

	private Vector3 moveDir;
	private Quaternion moveRot;
	private string carrying;


	void Start(){

		carrying = "nothing";
		carriedText.text = carrying;

		agriculture = 0; construction = 0; society = 0;
		aMul = 0;cMul = 0;sMul = 0;
		rock=0;wood=0;seed=0;horse=0;spice=0;paper=0;gold=0;
		stepper = 0;
	}
	void Update () {

		moveDir = new Vector3 (0, 0, Input.GetAxisRaw ("Vertical")).normalized;
//		moveRot = new Quaternion (Input.GetAxisRaw ("Horizontal"));
	}

	void OnTriggerEnter(Collider colision)
	{
		print("stepped on " +colision.gameObject.name);
		if (colision.gameObject.name == "home") {

			if(carrying!="nothing" && carrying!="home"){
			Arrived (carrying);

			}
			carrying = "nothing";		

		}else  {			
			carrying = colision.gameObject.name;
		}

		carriedText.text = carrying;


	}

	private int stepper;
	void FixedUpdate(){
		float speed = Input.GetAxisRaw("Horizontal") *turnSpeed* Time.deltaTime;
		transform.Rotate(0, speed, 0);
		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody>().position + GetComponent<Rigidbody>().transform.TransformDirection (moveDir) * moveSpeed * Time.deltaTime);

		stepper++;


		if (stepper >= 100) {
			
			agriculture += aMul;
			construction += cMul;
			society += sMul;

			agricultureText.text = (agriculture).ToString ();
			constructionText.text = (construction).ToString ();
			societyText.text = (society).ToString ();

			stepper = 0;
		}
	}
	public static int agriculture, construction, society;
	private int aMul,cMul,sMul,rock,wood,seed,horse,spice,paper,gold;

	public Text agricultureText, constructionText, societyText;

	public Text carriedText;

	void Arrived(string item){
		print ("carried : " + item);

			   if (item == "rock") {
			rock++;

			cMul++;					//Construction

		} else if (item == "wood") {
			wood++;

			cMul+=(1+rock);					//Construction

		} else if (item == "horse") {
			horse++;

			cMul+=(1+wood);					//Construction
			aMul+=(1+spice);					//Agriculture


		} else if (item == "seed") {
			seed++;

			aMul++;					//Agriculture


		} else if (item == "spice") {
			spice++;

			aMul += (1 + seed);					//Agriculture




		} else if (item == "paper") {
			paper++;

			sMul+=(2+gold);					//Society
		} else if (item == "gold") {
			gold++;

			sMul+=(1+2*paper);					//Society


		}


	}

	public void Die(){
		SceneManager.LoadScene("Over");

	}
}
