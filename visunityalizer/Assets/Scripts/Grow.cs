﻿using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(0, 0.1f, 0) * Time.deltaTime;
	}
}
