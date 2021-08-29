using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{

    public GameObject ProgressBar;
    public GameObject FailedEndScreen;
    public GameObject Email;
    public GameObject VictoryEndScreen;
    public GameObject Math9x7;
    public GameObject Math7x4;
    public GameObject Math2x8;
    public GameObject Math5x6;
    public int ClickCount = 0;

    void Start()
    {
        FailedEndScreen.SetActive(false);
        VictoryEndScreen.SetActive(false);
        ProgressBar.SetActive(false);
        Math9x7.SetActive(false);
        Math7x4.SetActive(false);
        Math2x8.SetActive(false);
        Math5x6.SetActive(false);
        Email.SetActive(true);
    }

    public void LetThereBeChaos()
    {
        Math9x7.SetActive(true);

        GameObject[] windowArray = GameObject.FindGameObjectsWithTag("window");
        for (int i = 0; i < windowArray.Length; i++)
        {
            Destroy(windowArray[1]);
        }

        Debug.Log("CHAOS!!!!!");
        // this is where we can start popping up the actual mini games
    }

    public void AddClick()
    {
        ClickCount++;

        if(ClickCount >= 10)
        {
            LetThereBeChaos();
        }
    }
  
}
