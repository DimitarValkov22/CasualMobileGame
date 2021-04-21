using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbCatchManager : MonoBehaviour
{
    public GameObject mainLogo;
    public GameObject[] menuText;
    public GameObject splashBackground;
    public GameObject gameMusic;
    public GameObject globalScripts;
    public GameObject countdownText;
    public GameObject tapButton;
    public GameObject[] finalText;
    public GameObject menuSound;

    void Start()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSecondsRealtime(1);
        mainLogo.SetActive(true);
        yield return new WaitForSecondsRealtime(6);
        mainLogo.SetActive(false);
        menuSound.SetActive(true);
        menuText[0].SetActive(true);
        menuText[1].SetActive(true);
        tapButton.SetActive(true);
    }

    public void TapToStart()
    {
        tapButton.SetActive(false);
        menuText[0].SetActive(false);
        menuText[1].SetActive(false);
        menuSound.SetActive(false);
        splashBackground.GetComponent<Animator>().Play("SplashFadeOut");
        StartCoroutine(BeginTheGame());
    }

    IEnumerator BeginTheGame()
    {
        finalText[0].SetActive(false);
        finalText[1].SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        countdownText.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        countdownText.GetComponent<Text>().text = "2";
        yield return new WaitForSecondsRealtime(1);
        countdownText.GetComponent<Text>().text = "1";
        yield return new WaitForSecondsRealtime(1);
        countdownText.SetActive(false);
        countdownText.GetComponent<Text>().text = "3";
        gameMusic.SetActive(true);
        splashBackground.SetActive(false);
        globalScripts.GetComponent<Time>().enabled = true;
        globalScripts.GetComponent<OrbGenerator>().enabled = true;
    }
}
