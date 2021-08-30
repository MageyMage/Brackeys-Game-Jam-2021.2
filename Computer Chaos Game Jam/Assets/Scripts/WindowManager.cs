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
    public GameObject MathQuestion;
    public int ClickCount = 0;
    public Vector3 spawnPosition;

    void Start()
    {
        FailedEndScreen.SetActive(false);
        VictoryEndScreen.SetActive(false);
        ProgressBar.SetActive(false);
        Email.SetActive(true);
    }

    public void LetThereBeChaos()
    {
        spawnPosition = RandomPointInBounds();
        GameObject MathQuestionInstance = Instantiate(MathQuestion, spawnPosition, Quaternion.identity) as GameObject;
        MathQuestionInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);

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

    public static Vector3 RandomPointInBounds()
    {
        //max x: -15 min x: -85
        //max y: 12 min y: 2
        return new Vector3(
           Random.Range(-85, -15),
           Random.Range(2, 12),
           0f
        );
    }

}
