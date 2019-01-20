using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExtraParticles : MonoBehaviour {
    public ParticleSystem PlayerOneParticles1;
    public ParticleSystem PlayerOneParticles2;
    public ParticleSystem PlayerTwoParticles3;
    public ParticleSystem PlayerTwoParticles4;

    public AudioSource congratsNarration;
    public AudioSource congratsMusic;

    public GameObject congratsPanelParent;
    public GameObject congratsPanel;
    
    // Use this for initialization
    void Start () {
        congratsNarration.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        PlayerOneParticles1.Play();
        PlayerOneParticles2.Play();
        PlayerTwoParticles3.Play();
        PlayerTwoParticles4.Play();

        congratsNarration.Play();
        congratsPanelParent.SetActive(true);
        congratsPanel.SetActive(true);
        DestroyAllObjects();
        congratsMusic.Play();
    }
    void DestroyAllObjects()
    {
        GameObject continousMusic = GameObject.FindGameObjectWithTag("MainGameMusic");
        GameObject.Destroy(continousMusic);
    }
}

