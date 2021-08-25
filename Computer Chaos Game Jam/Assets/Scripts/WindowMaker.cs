using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WindowMaker : MonoBehaviour
{

    public GameObject okWindow;
    public Vector3 spawnPosition;
    public int ClickCounter;

    public void AddWindow()
    {
        int i = 0;
        ClickCounter++;
        while (i < Random.Range(1, 4)) // repeats
        {
            //spawns a button
            spawnPosition = RandomPointInBounds();
            GameObject okWindowInstance = Instantiate(okWindow, spawnPosition, Quaternion.identity) as GameObject;
            okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
            i++;
        }


        if(ClickCounter >= 10)
        {
            Debug.Log("Start Chaos");
        }
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
