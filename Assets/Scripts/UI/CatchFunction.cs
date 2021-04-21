using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunction : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject middlePlatform;
    public GameObject rightPlatform;
    public bool activePlat = false;
  //  public AudioSource platformActiveSound;

   public void leftPlat()
    {
        if(activePlat == false)
        {
            activePlat = true;
           // platformActiveSound.Play();
           leftPlatform.SetActive(true);
           StartCoroutine(LeftReset());
        }
        
    }

    public void middlePlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
           // platformActiveSound.Play();
            middlePlatform.SetActive(true);
            StartCoroutine(MidReset());
        }
    }

    public void rightPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
           // platformActiveSound.Play();
            rightPlatform.SetActive(true);
            StartCoroutine(RightReset());
        }
    }

    IEnumerator LeftReset()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        leftPlatform.SetActive(false);
        activePlat = false;
    }

    IEnumerator MidReset()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        middlePlatform.SetActive(false);
        activePlat = false;
    }

    IEnumerator RightReset()
    {
        yield return new WaitForSecondsRealtime(0.15f);
        rightPlatform.SetActive(false);
        activePlat = false; 
    }
}
