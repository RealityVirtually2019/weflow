using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TriggerEvent_01 : MonoBehaviour
{

    public Animator anim;
    public GameObject B_Target_R_JustDoIt;

    public Animator particle_anim;
    public Animator line_anim;
    public GameObject Particles;
    public GameObject Line;

    public AudioSource firstTouchNarration;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        firstTouchNarration.GetComponent<AudioSource>();
        anim.Play("Target_TransitionOn");
    }

    private void OnTriggerEnter(Collider other)
    {
        Particles.SetActive(true);
        Line.SetActive(true);
        particle_anim = Particles.GetComponent<Animator>();
        line_anim = Line.GetComponent<Animator>();


        anim.Play("Target_TransitionOff");
        particle_anim.Play("Trans_1_2");
        line_anim.Play("Trans_1_2_Line");
        gameObject.GetComponent<AudioSource>().Play();
        firstTouchNarration.Play();
        B_Target_R_JustDoIt.SetActive(true);
        Destroy(GetComponent<SphereCollider>());
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}