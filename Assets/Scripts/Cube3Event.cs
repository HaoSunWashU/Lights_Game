﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3Event : MonoBehaviour {
	public GameObject neighbor2;
	public GameObject neighbor6;
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
		neighbor2.GetComponent<Renderer> ().sharedMaterial = neighbor2.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];
		neighbor6.GetComponent<Renderer> ().sharedMaterial = neighbor6.GetComponent<Renderer> ().sharedMaterial == materials [0]?materials [1] : materials [0];

	}
}
