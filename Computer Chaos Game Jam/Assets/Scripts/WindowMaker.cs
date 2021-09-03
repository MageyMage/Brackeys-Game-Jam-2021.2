using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WindowMaker : MonoBehaviour
{

    public GameObject OkWindow;

    public void AddWindow()
    {
        GameObject WindowManager = GameObject.Find("StuffManager");
        WindowManager.GetComponent<WindowManager>().CreateOkWindow();
        Destroy(OkWindow);

    }

}
