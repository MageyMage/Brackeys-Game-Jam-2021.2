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
            okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
            okWindowInstance.transform.SetAsFirstSibling();
            i++;
        }

        ProgressBar.GetComponent<ProgressBar>().DecreaseFill();
    }


    //minimum x is -94 maximum x is 96
    //maximum y is 45 minimum y is -37
    //idk why but the box colliders numbers are really low
    public static Vector3 RandomPointInBounds()
    {
        return new Vector3(
           Random.Range(-94, 96),
           Random.Range(-37, 45),
           0f
        );
    }
}
