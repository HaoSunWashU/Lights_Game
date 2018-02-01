using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Event : MonoBehaviour {
	public GameObject neighbor2;
	public GameObject neighbor4;
	public Material[] materials;
	private Renderer rend;
	private bool changed = false;


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = materials [0];
//		neighbor2.GetComponent<Renderer> ().sharedMaterial = materials [1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		rend.sharedMaterial = rend.sharedMaterial == materials [0] ? materials [1] : materials [0];
		neighbor2.GetComponent<Renderer> ().sharedMaterial = neighbor2.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor4.GetComponent<Renderer> ().sharedMaterial = neighbor4.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];


//		//		rend.sharedMaterial = materials [1];
//		if (changed == true) {
//			rend.sharedMaterial = materials [0];
//			neighbor2.GetComponent<Renderer> ().sharedMaterial = materials [0];
//			neighbor4.GetComponent<Renderer> ().sharedMaterial = materials [0];
//			changed = false;
//		} 
//		else {
//			rend.sharedMaterial = materials [1];
//			neighbor2.GetComponent<Renderer> ().sharedMaterial = materials [1];
//			neighbor4.GetComponent<Renderer> ().sharedMaterial = materials [1];
//			changed = true;
//		}
	}
}
