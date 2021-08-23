using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OKScript : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite pressedSprite;
    public Sprite unpressedSprite;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Check for mouse input
        if (Input.GetMouseButtonDown(0))
         {
        	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         	RaycastHit hit;
        	// Casts the ray and get the first game object hit
         	Physics.Raycast(ray, out hit);
            ChangeSpritePressed();
         	Debug.Log("This hit at " + hit.point );
        }

        if (Input.GetMouseButtonUp(0))
        {
            
            ChangeSpriteUnpressed();

		}
    }

    void ChangeSpritePressed()
    {
        spriteRenderer.sprite = pressedSprite; 
    }

    void ChangeSpriteUnpressed()
    {
        spriteRenderer.sprite = unpressedSprite; 
    }
}

    
