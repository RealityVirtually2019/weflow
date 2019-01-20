using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TriggerEvent_01 : MonoBehaviour
{

    public Animator anim;
    public GameObject B_Target_R_JustDoIt;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Target_TransitionOn");
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("Target_TransitionOff");
        //this.SetActive(false);
        B_Target_R_JustDoIt.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}