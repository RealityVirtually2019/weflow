using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TriggerEvent_05 : MonoBehaviour
{

    public Animator anim;
    public GameObject F_Target_StretchDown;

    public Animator particle_anim;
    public Animator line_anim;
    public GameObject Particles;
    public GameObject Line;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        particle_anim = Particles.GetComponent<Animator>();
        line_anim = Line.GetComponent<Animator>();

        anim.Play("Target_TransitionOn");
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("Target_TransitionOff");
        particle_anim.Play("Trans_5_6");
        line_anim.Play("Trans_5_6_Line");
        F_Target_StretchDown.SetActive(true);
        Destroy(GetComponent<SphereCollider>());
    }

    // Update is called once per frame
    void Update()
    {

    }
}