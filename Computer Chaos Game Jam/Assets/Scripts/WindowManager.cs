using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    //script to handle spawing windows

    public GameObject firstOKWindow;
    public GameObject okWindow;
    public GameObject ProgressBar;
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

    public void SpawnOKWindow(){
        spawnPosition = RandomPointInBounds();
        okWindowInstance = Instantiate(okWindow, spawnPosition, Quaternion.identity) as GameObject;
        Debug.Log("Spawning Window, at pos: " + spawnPosition.ToString());
        okWindowInstance.transform.SetParent(GameObject.FindGameObjectWithTag("canvasy").transform, false);
    }

    
    public void addButtonListener(GameObject okWindowInstance){
        okButton = okWindowInstance.transform.GetChild(0).gameObject.GetComponent<Button>();
        okButton.onClick.AddListener(SpawnOKWindow);
	}
    //minimum x is -94 maximum x is 96
    //maximum y is 45 minimum y is -37
    //idk why but the box colliders numbers are really low
    public static Vector3 RandomPointInBounds() {
        return new Vector3(
           Random.Range(-94, 96),
           Random.Range(-37, 45),
           0f
        );
    }

    public void LetThereBeChaos()
    {
        ProgressBar.SetActive(true);
        Debug.Log("CHAOS!!!!!");
        // this is where we can start popping up the actual mini games
    }
  
}
