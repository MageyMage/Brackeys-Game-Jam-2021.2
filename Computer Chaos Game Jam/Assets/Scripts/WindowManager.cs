using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    
    //script to handle spawing windows

    public GameObject firstOKWindow;
    public GameObject okWindow;
    private Vector3 spawnPosition;

    public BoxCollider2D windowArea;

    private bool addListener = false;
    private GameObject okWindowInstance;

    private GameObject buttonGameObject;
    private Button okButton;

    void Start()
    {
        buttonGameObject = firstOKWindow.transform.GetChild(0).gameObject;

        okButton = buttonGameObject.GetComponent<Button>();
        okButton.onClick.AddListener(SpawnOKWindow);
    }


    void Update()
    {
       
    }

    public void SpawnOKWindow(){
        
        Debug.Log("Spawning Window");
        spawnPosition = new Vector3(0.0f, 0.0f, 0.0f);
        okWindowInstance = Instantiate(okWindow, RandomPointInBounds(windowArea.bounds), Quaternion.identity) as GameObject;
        okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
        
        addButtonListener(okWindowInstance);
	}

    
    public void addButtonListener(GameObject okWindowInstance){
        okButton = okWindowInstance.transform.GetChild(0).gameObject.GetComponent<Button>();
        okButton.onClick.AddListener(SpawnOKWindow);
	}

    public static Vector3 RandomPointInBounds(Bounds bounds) {
        return new Vector3(
           Random.Range(bounds.min.x, bounds.max.x),
           Random.Range(bounds.min.y, bounds.max.y),
           0f
        );
    }
}
