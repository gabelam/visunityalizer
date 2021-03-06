﻿using UnityEngine;
using System.Collections;
using System;

public class FFT : MonoBehaviour {

	public float[] spectrum;

    public GameObject[] visualBuckets;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		spectrum = GetComponent<AudioSource>().GetSpectrumData(1024, 0, FFTWindow.BlackmanHarris);

		int i = 1;
        //while (i < 1023) {
        //    Debug.DrawLine(new Vector3(i - 1, spectrum[i] + 10, 0), new Vector3(i, spectrum[i + 1] + 10, 0), Color.red);
        //    Debug.DrawLine(new Vector3(i - 1, Mathf.Log(spectrum[i - 1]) + 10, 2), new Vector3(i, Mathf.Log(spectrum[i]) + 10, 2), Color.cyan);
        //    Debug.DrawLine(new Vector3(Mathf.Log(i - 1), spectrum[i - 1] - 10, 1), new Vector3(Mathf.Log(i), spectrum[i] - 10, 1), Color.green);
        //    Debug.DrawLine(new Vector3(Mathf.Log(i - 1), Mathf.Log(spectrum[i - 1]), 3), new Vector3(Mathf.Log(i), Mathf.Log(spectrum[i]), 3), Color.yellow);
        //    i++;
        //}

        for (i = 0; i < visualBuckets.Length; ++i)
        {
            visualBuckets[i].transform.localScale = new Vector3(0.75f, 100 * spectrum[i], 1);
        }
	}
}