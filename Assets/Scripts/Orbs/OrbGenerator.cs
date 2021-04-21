using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbGenerator : MonoBehaviour
{
    public GameObject[] orbFall;
    public bool generatingOrb = false;
    public int orbLocation;
    public int orbColor;
    public float xPosition;

    void Update()
    {
        if (generatingOrb == false)
        {
            generatingOrb = true;
            orbLocation = Random.Range(1, 4);
            orbColor = Random.Range(0, 3);
            if(orbLocation == 1)
            {
                xPosition = -1.6f;
            }
            if (orbLocation == 2)
            {
                xPosition = 0;
            }
            if (orbLocation == 3)
            {
                xPosition = 1.6f;
            }
            StartCoroutine(OrbFalling());
        }
    }

    IEnumerator OrbFalling()
    {
        Instantiate(orbFall[orbColor], new Vector3(xPosition, 12, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.38f);
        generatingOrb = false;
    }
}
