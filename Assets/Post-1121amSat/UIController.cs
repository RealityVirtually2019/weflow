using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public RawImage splashPage;
    public RawImage panel1;
    public RawImage panel2;
    public RawImage handicon;
    public GameObject handIconCollider;

    // Use this for initialization
    void Start () {
        float alpha = 255f;
        splashPage.CrossFadeAlpha(alpha, 3.0f, false);
        

        //splashPage.CrossFadeAlpha(1, 3.0f, false);
        EndSplashPage();
	}

    public void EndSplashPage()
    {
        StartCoroutine(FadeOutSplashPage());
    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator FadeOutSplashPage()
    {
        yield return new WaitForSeconds(3);
        float alpha = 1;
        splashPage.CrossFadeAlpha(alpha, 3.0f, false);
        StartCoroutine(DisplayPanel1());

    }
    IEnumerator DisplayPanel1()
    {
        yield return new WaitForSeconds(3);
        float alpha = 255;
        panel1.CrossFadeAlpha(alpha, 3.0f, false);
        panel2.CrossFadeAlpha(alpha, 3.0f, false);
        handicon.CrossFadeAlpha(alpha, 3.0f, false);
        handIconCollider.SetActive(true);
    }



}


