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
        this.transform.position = MLcam.transform.position;// + MLcam.transform.forward * 0.5f;
        Vector3 forward = MLcam.transform.forward;
        forward.y = 0;
        this.transform.forward = forward.normalized;

    }

    // Update is called once per frame
    void Update()
    {

    }
}


