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
        if(addListener){
            okButton = okWindowInstance.transform.GetChild(0).gameObject.GetComponent<Button>();
            okButton.onClick.AddListener(SpawnOKWindow);

            addListener = false;
		}
    }

    public void SpawnOKWindow(){
        
        Debug.Log("ooo");
        spawnPosition = new Vector3(0.0f, 0.0f, 0.0f);
        okWindowInstance = Instantiate(okWindow) as GameObject;
        okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
        
        addListener = true;
	}
}
