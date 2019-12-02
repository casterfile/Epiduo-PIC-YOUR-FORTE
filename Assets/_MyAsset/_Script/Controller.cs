using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	public Image Picture;
	private GameObject Notice_1,Notice_2,Notice_3,Notice_3_DraggingObject,Notice_4;
	public GameObject PictureCon;
//	CameraUI
	// Use this for initialization
	void Start () {
		Picture = CameraController.gPicture;
		PictureCon.SetActive (true);
		DraggingObjects.PimplesCount = 0;
//		CameraUI = GameObject.Find("CameraUI").GetComponent<Image>();
//		float alpha = 1.0f;
//		CameraUI.color.a = alpha;

		Notice_1 = GameObject.Find ("Notice_1");
		Notice_2 = GameObject.Find ("Notice_2");
		Notice_3 = GameObject.Find ("Notice_3");
		Notice_3_DraggingObject = GameObject.Find ("Notice_3 _DraggingObject");
		Notice_4 = GameObject.Find ("Notice_4");

		Notice_1.SetActive (true);
		Notice_2.SetActive (false);
		Notice_3.SetActive (false);
		Notice_3_DraggingObject.SetActive (false);
		Notice_4.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(DraggingObjects.PimplesCount == 4){
			FuncNotice_4 ();
		}
	}

	public void Function(string FuncName){
		if(FuncName == "Notice_2"){FuncNotice_2 ();}
		if(FuncName == "Notice_3"){FuncNotice_3 ();}
	}

	void FuncNotice_2(){
		Notice_1.SetActive (false);
		Notice_2.SetActive (true);
	}

	void FuncNotice_3(){
		Notice_2.SetActive (false);
		Notice_3.SetActive (true);
		Notice_3_DraggingObject.SetActive (true);
	}

	void FuncNotice_4(){
		Notice_3.SetActive (false);
		Notice_3_DraggingObject.SetActive (false);
		Notice_4.SetActive (true);
	}
}

