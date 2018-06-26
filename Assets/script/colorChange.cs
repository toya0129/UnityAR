using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour {

	private Renderer arRen;
	public Material[] mate;
	private int ran;

	public bool ct;

	// Use this for initialization
	void Start () {
		arRen = this.GetComponent<Renderer> ();
		ct = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (ct == true) {
			change ();
		}
	}

	public void change (){
		Debug.Log (ran);
		ran = Random.Range (0, 5);
		arRen.material = mate [ran];
		ct = false;
	}
}
