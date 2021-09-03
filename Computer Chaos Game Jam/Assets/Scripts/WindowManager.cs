using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    //actual gameobjects
    public GameObject ProgressBar;
    public GameObject ProgressBarPopup;
    public GameObject FailedEndScreen;
    public GameObject Email;
    public GameObject VictoryEndScreen;

    //prefabs
    public GameObject MathQuestion;
    public GameObject okWindow;

    //variables
    private int ClickCount = 0;
    private Vector3 spawnPosition;

    //sprites
    public Sprite[] spriteList;


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

        //changes the sprite
        int mathQuestionIndex = Random.Range(0, 3);
        MathQuestionInstance.GetComponent<Image>().sprite = spriteList[mathQuestionIndex];

        //changes the correct answer
        var answer = MathQuestionInstance.GetComponent<SliderController>();
        switch (mathQuestionIndex)
        {
            case 0: // 9x7
                answer.CorrectAnswer = 3;
                break;
            case 1: // 7x4
                answer.CorrectAnswer = 1;
                break;
            case 2: // 5x6
                answer.CorrectAnswer = 3;
                break;
            case 3: // 2x8
                answer.CorrectAnswer = 4;
                break;
            default:
                Debug.Log("Something went wrong with making the correct answer, maybe check that the number of cases is equal to the random range");
                break;
        } 

        //puts it into the canvas
        MathQuestionInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
        MathQuestionInstance.transform.SetAsLastSibling();
        Debug.Log("Created a math problem at " + spawnPosition.ToString());
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

            //puts it into the canvas
            okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("OKwindowParent").transform, false);
            okWindowInstance.transform.SetAsFirstSibling();
            okWindowInstance.SetActive(true);
            Debug.Log("Created a window at " + spawnPosition.ToString() + " Click Count is " + ClickCount);
            i++;
        }

        AddClick();

        ProgressBar.GetComponent<ProgressBar>().DecreaseFill(5);
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
