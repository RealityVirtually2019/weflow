using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TriggerEvent_07 : MonoBehaviour
{

    public Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Target_TransitionOn");
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("Target_TransitionOff");
        Destroy(GetComponent<SphereCollider>());
    }

    // Update is called once per frame
    void Update()
    {

    }
}