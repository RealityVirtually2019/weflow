using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class InitializePosition : MonoBehaviour {

    public Camera _cam;

	// Use this for initialization
	void Start () {
        this.transform.position = _cam.transform.forward * 1f;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
