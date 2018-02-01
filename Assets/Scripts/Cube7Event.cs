using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube7Event : MonoBehaviour {
	public GameObject neighbor4;
	public GameObject neighbor8;

	public Material[] materials;
	private Renderer rend;

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
		neighbor4.GetComponent<Renderer> ().sharedMaterial = neighbor4.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor8.GetComponent<Renderer> ().sharedMaterial = neighbor8.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
	}
}
