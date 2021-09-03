using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{

    public GameObject ProgressBar;
    public GameObject ProgressBarPopup;
    public GameObject FailedEndScreen;
    public GameObject Email;
    public GameObject VictoryEndScreen;
    public GameObject MathQuestion;
    public GameObject okWindow;
    public int ClickCount = 0;
    public Vector3 spawnPosition;

    void Start()
    {
        FailedEndScreen.SetActive(false);
        VictoryEndScreen.SetActive(false);
        ProgressBarPopup.SetActive(false);
        Email.SetActive(true);
    }

    public void LetThereBeChaos()
    {
        CreateMathWindow();
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

    public void CreateMathWindow()
    {
        //spawns a math problem
        spawnPosition = RandomPointInBoundsMathWindow();
        GameObject MathQuestionInstance = Instantiate(MathQuestion, spawnPosition, Quaternion.identity) as GameObject;
        MathQuestionInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
        MathQuestionInstance.transform.SetAsLastSibling();
    }

    public static Vector3 RandomPointInBoundsMathWindow()
    {
        return new Vector3(
           Random.Range(-85, -15), // x
           Random.Range(2, 12), // y
           0f
        );
    }

    public void CreateOkWindow()
    {
        int i = 0;
        while (i < Random.Range(2, 3)) // repeats
        {
            //spawns a button
            spawnPosition = RandomPointInBoundsOkWindow();
            GameObject okWindowInstance = Instantiate(okWindow, spawnPosition, Quaternion.identity) as GameObject;
            okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("OKwindowParent").transform, false);
            okWindowInstance.transform.SetAsFirstSibling();
            i++;
        }

        ProgressBar.GetComponent<ProgressBar>().DecreaseFill();
    }

    public static Vector3 RandomPointInBoundsOkWindow()
    {
        return new Vector3(
           Random.Range(-153, 53), // x
           Random.Range(-34, 50), // y
           0f
        );
    }


}
