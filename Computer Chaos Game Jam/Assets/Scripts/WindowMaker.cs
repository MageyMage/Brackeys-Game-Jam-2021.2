using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WindowMaker : MonoBehaviour
{

    public GameObject WindowManager;

    public void AddWindow()
    {

        WindowManager.GetComponent<WindowManager>().CreateOkWindow();

    }

}
