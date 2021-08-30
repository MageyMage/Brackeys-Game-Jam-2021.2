using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WindowMaker : MonoBehaviour
{

    public GameObject okWindow;
    public Vector3 spawnPosition;
    public GameObject ProgressBar;
    public GameObject WindowManager;

    public void AddWindow()
    {
        int i = 0;
        while (i < Random.Range(2, 3)) // repeats
        {
            //spawns a button
            spawnPosition = RandomPointInBounds();
            GameObject okWindowInstance = Instantiate(okWindow, spawnPosition, Quaternion.identity) as GameObject;
            okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("OKwindowParent").transform, false);
            okWindowInstance.transform.SetAsFirstSibling();
            i++;
        }

        ProgressBar.GetComponent<ProgressBar>().DecreaseFill();
    }


    //minimum x is -200 maximum x is 100
    //maximum y is 100 minimum y is -85
    //idk why but the box colliders numbers are really low
    //min max numbers are off
    public static Vector3 RandomPointInBounds()
    {
        return new Vector3(
           Random.Range(-153, 53),
           Random.Range(-34, 50),
           0f
        );
    }
}
