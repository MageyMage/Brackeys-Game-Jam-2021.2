using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    
    //script to handle spawing windows

    public GameObject okWindow;
    private Vector3 spawnPosition;

    public Transform canvas;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void SpawnOKWindow(){
        
        spawnPosition = new Vector3(0.0f, 0.0f, 0.0f);
        GameObject instance = Instantiate(okWindow) as GameObject;
        instance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
	}
}
