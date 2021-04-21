using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int orbScore;
    public GameObject orbDisplay;
    public static int orbCount;

    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "Score: " + orbScore;
        orbDisplay.GetComponent<Text>().text = "Orbs: " + orbCount;
    }
}
