﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame
	void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
