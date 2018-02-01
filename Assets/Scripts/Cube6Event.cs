using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube6Event : MonoBehaviour {
	public GameObject neighbor3;
	public GameObject neighbor5;
	public GameObject neighbor9;
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
		neighbor3.GetComponent<Renderer> ().sharedMaterial = neighbor3.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor5.GetComponent<Renderer> ().sharedMaterial = neighbor5.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor9.GetComponent<Renderer> ().sharedMaterial = neighbor9.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];

	}
}
