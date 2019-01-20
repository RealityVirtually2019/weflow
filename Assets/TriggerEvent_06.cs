using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class TriggerEvent_06 : MonoBehaviour
{

    public Animator anim;
    public GameObject G_Target_Final;

    public Animator particle_anim;
    public Animator line_anim;
    public GameObject Particles;
    public GameObject Line;

    public AudioSource secondLastStarNarration;

    public GameObject finalStars;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        particle_anim = Particles.GetComponent<Animator>();
        line_anim = Line.GetComponent<Animator>();
        secondLastStarNarration.GetComponent<AudioClip>();
        anim.Play("Target_TransitionOn");
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.Play("Target_TransitionOff");
        particle_anim.Play("Trans_6_7");
        line_anim.Play("Trans_6_7_Line");
        gameObject.GetComponent<AudioSource>().Play();
        secondLastStarNarration.Play();
        finalStars.SetActive(true);
        G_Target_Final.SetActive(true);
        Destroy(GetComponent<SphereCollider>());
    }

    // Update is called once per frame
    void Update()
    {

    }
}