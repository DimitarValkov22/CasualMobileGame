using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;
    internal static float time;
    public bool isZero = false;
    public GameObject splashBackground;
    public GameObject gameMusic;
    public GameObject globalScripts;
    public GameObject tapButton;
    public GameObject finalScore;
    public GameObject finalOrbs;
    public GameObject tapToBeginText;

    public GameObject menuSound;

    void Update()
    {
        if(countingDown == false && isZero ==false)
        {
            countingDown = true;
            StartCoroutine(SubtractSecond());
        }
        if(isZero == true)
        {
            StartCoroutine(GameOver());
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1);
        currentSeconds -= 1;
        if(currentSeconds == 0)
        {
            isZero = true;
        }
        timeDisplay.GetComponent<Text>().text = "Time: " + currentSeconds;
        countingDown = false;
    }

    IEnumerator GameOver()
    {
        splashBackground.SetActive(true);
        splashBackground.GetComponent<Animator>().Play("SplashFadeIn");
        gameMusic.SetActive(false);
        globalScripts.GetComponent<Time>().enabled = false;
        globalScripts.GetComponent<OrbGenerator>().enabled = false;
        yield return new WaitForSecondsRealtime(2);
        menuSound.SetActive(true);
        finalScore.GetComponent<Text>().text = "Your score is:  " + ScoreUpdater.orbScore;
        finalOrbs.GetComponent<Text>().text = "Orbs collected: " + ScoreUpdater.orbCount;
        finalScore.SetActive(true);
        finalOrbs.SetActive(true);
        tapToBeginText.SetActive(true);
        tapButton.SetActive(true);
        currentSeconds = 30;
        isZero = false;
        ScoreUpdater.orbCount = 0;
        ScoreUpdater.orbScore = 0;
        yield return new WaitForSecondsRealtime(0.3f);
        globalScripts.GetComponent<Time>().enabled = false;
    }
}
