using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class InitializePosition2 : MonoBehaviour
{

    public GameObject _target;

    // Use this for initialization
    void Start()
    {
        this.transform.position = _target.transform.up * 1f;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
