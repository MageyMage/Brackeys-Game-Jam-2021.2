using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OKScript : MonoBehaviour
{

    public Sprite pressedSprite;
    public Sprite unpressedSprite;
	public SpriteRenderer sr;

    private bool selected;
	private bool clickedOn;

	void Update(){
	
		if (selected == true){
			sr.sprite = pressedSprite;
		}

		if (clickedOn == true){
			Debug.Log("ok");
		}

		if(Input.GetMouseButtonUp(0)){
			selected = false;
			sr.sprite = unpressedSprite;
		}
	}

	void OnMouseOver(){
	
		if(Input.GetMouseButtonDown(0)){
			selected = true;
		}

		if(Input.GetMouseButtonUp(0)){
			clickedOn = true;
		}
	}
}


    
