using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailScript : MonoBehaviour
{

    public GameObject ProgressBar;
    public GameObject Email;
    public GameObject WindowManager;
    public GameObject FirstOkWindow;

    void Start()
    {
        ProgressBar.SetActive(false);
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
        FirstOkWindow.SetActive(true);
    }
}
