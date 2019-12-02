using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggingObjects : MonoBehaviour {
	string CurrentPimples;
	GameObject Pimples_1,Pimples_2,Pimples_3,Pimples_4;
	public static int PimplesCount;
	bool isPimples_1,isPimples_2,isPimples_3,isPimples_4;
	// Use this for initialization
	void Start(){
		PimplesCount = 0;
		PimplesCount = 0;
		isPimples_1 = isPimples_2 = isPimples_3 = isPimples_4 = false;
		Pimples_1 = GameObject.Find ("Pimples_1");
		Pimples_1.SetActive (true);
		Pimples_2 = GameObject.Find ("Pimples_2");
		Pimples_2.SetActive (true);
		Pimples_3 = GameObject.Find ("Pimples_3");
		Pimples_3.SetActive (true);
		Pimples_4 = GameObject.Find ("Pimples_4");
		Pimples_4.SetActive (true);
	}
	public void Drag () {
		GameObject.Find ("Notice_3 _DraggingObject").transform.position = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RemovePimple(){
		if(CurrentPimples == "Pimples_1"){
			Pimples_1.SetActive (false);
			Pimples_1.GetComponent<BoxCollider2D> ().enabled = false; 
			if(isPimples_1 == false){
				isPimples_1 = true;
				PimplesCount++;
			}

		}
		if(CurrentPimples == "Pimples_2"){
			Pimples_2.SetActive (false);
			Pimples_2.GetComponent<BoxCollider2D> ().enabled = false;
			if(isPimples_2 == false){
				isPimples_2 = true;
				PimplesCount++;
			}
		}
		if(CurrentPimples == "Pimples_3"){
			Pimples_3.SetActive (false);
			Pimples_3.GetComponent<BoxCollider2D> ().enabled = false;
			if(isPimples_3 == false){
				isPimples_3 = true;
				PimplesCount++;
			}
		}
		if(CurrentPimples == "Pimples_4"){
			Pimples_4.SetActive (false);
			Pimples_4.GetComponent<BoxCollider2D> ().enabled = false;
			if(isPimples_4 == false){
				isPimples_4 = true;
				PimplesCount++;
			}
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.name == "Pimples_1"){
			CurrentPimples = "Pimples_1";
		}
		if(col.name == "Pimples_2"){
			CurrentPimples = "Pimples_2";
		}
		if(col.name == "Pimples_3"){
			CurrentPimples = "Pimples_3";
		}
		if(col.name == "Pimples_4"){
			CurrentPimples = "Pimples_4";
		}
	}

}
