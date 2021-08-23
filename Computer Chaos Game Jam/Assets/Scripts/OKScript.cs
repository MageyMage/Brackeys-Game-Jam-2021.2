using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKScript : MonoBehaviour
{

    public Sprite pressedSprite;
    public Sprite unpressedSprite;

    public Button okButton;

    void Start ()
    {
        Button btn = okButton.GetComponent<Button>();
        btn.onClick.AddListener(taskOnClick);
	}

    void taskOnClick()
    {
        Debug.Log("fjdsklafjdsalk");
	}
}

    
