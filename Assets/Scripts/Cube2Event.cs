using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Event : MonoBehaviour {
	public GameObject neighbor1;
	public GameObject neighbor3;
	public GameObject neighbor5;
	public Material[] materials;
	private Renderer rend;
	private bool changed = false;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = materials [0];
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		rend.sharedMaterial = rend.sharedMaterial == materials [0] ? materials [1] : materials [0];
		neighbor1.GetComponent<Renderer> ().sharedMaterial = neighbor1.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor3.GetComponent<Renderer> ().sharedMaterial = neighbor3.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor5.GetComponent<Renderer> ().sharedMaterial = neighbor5.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
//		//		rend.sharedMaterial = materials [1];
//		if (changed == true) {
//			rend.sharedMaterial = materials [0];
//			neighbor1.GetComponent<Renderer> ().sharedMaterial = materials [0];
//			neighbor3.GetComponent<Renderer> ().sharedMaterial = materials [0];
//			neighbor5.GetComponent<Renderer> ().sharedMaterial = materials [0];
//			changed = false;
//		} 
//		else {
//			rend.sharedMaterial = materials [1];
//			neighbor1.GetComponent<Renderer> ().sharedMaterial = materials [1];
//			neighbor3.GetComponent<Renderer> ().sharedMaterial = materials [1];
//			neighbor5.GetComponent<Renderer> ().sharedMaterial = materials [1];
//			changed = true;
//		}
	}
}
