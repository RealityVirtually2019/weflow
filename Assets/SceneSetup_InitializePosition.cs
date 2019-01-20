using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class SceneSetup_InitializePosition : MonoBehaviour
{

    public Camera MLcam;

    // Use this for initialization
    void Start()
    {
        this.transform.position = MLcam.transform.forward * 0.5f;

    }

    // Update is called once per frame
    void Update()
    {

    }
}


