﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TriggerAction : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("SphereTriggerActivated");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
