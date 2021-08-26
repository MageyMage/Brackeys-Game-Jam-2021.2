using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailScript : MonoBehaviour
{

    public GameObject ErrorWindow;
    public GameObject ProgressBar;
    public GameObject Email;

    void Start()
    {
        ProgressBar.SetActive(false);
        ErrorWindow.SetActive(false);
        Email.SetActive(true);
    }

    public void OnClick_()
    {
        Email.SetActive(false);
        Invoke("ActivateGame", 1);
    }
    void ActivateGame()
    {
        ProgressBar.SetActive(true);
        ErrorWindow.SetActive(true);
    }
}
