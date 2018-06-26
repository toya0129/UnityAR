using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

	public colorChange cc;

	public GameObject ar;
	public static bool trigger;
	private bool cct;

	public Text tx;
	private int ran;

	private string start;
	private string change;

	// Use this for initialization
	void Start () {
		cct = true;
		trigger = false;
		start = "カメラに\r\n写真をかざす";
		change = "オブジェクトをタッチ";
	}
	
	// Update is called once per frame
	void Update () {
		ar.SetActive (trigger);

		if (trigger == true) {
			tx.text = change;
			if (cct == true) {
				cc.ct = true;
				cct = false;
			}
		} else {
			tx.text = start;
			cct = true;
		}
	}



	public void VideoPlay(){
		Debug.Log ("再生開始");
		Handheld.PlayFullScreenMovie ("FloorPadPV.mp4", new Color (0, 0, 0));
	}
		
}
