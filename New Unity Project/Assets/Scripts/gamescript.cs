﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gamescript : MonoBehaviour {


    public int maxpoints;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void loadlevel(string x)
    {
        SceneManager.LoadScene(x);
    }
}
