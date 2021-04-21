using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCatch : MonoBehaviour
{
    public AudioSource orbCatchAudio;

     void OnTriggerEnter(Collider other)
    {
        orbCatchAudio.Play();
        if (other.tag == "RedOrb")
        {
            ScoreUpdater.orbScore += 1;
        }
        if (other.tag == "BlueOrb")
        {
            ScoreUpdater.orbScore += 2;
        }
        if (other.tag == "GreenOrb")
        {
            ScoreUpdater.orbScore += 3;
        }
        ScoreUpdater.orbCount += 1;
        other.gameObject.SetActive(false);
    }
}
