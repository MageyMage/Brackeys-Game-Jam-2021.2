using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragScript : MonoBehaviour, IPointerDownHandler {
    
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;

    private void Awake(){
    
        rectTransform = GetComponent<RectTransform>();

	}

    public void OnBeginDrag(PointerEventData eventData){
    
        
	}

    public void OnDrag(PointerEventData eventData){
    
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
	}

    public void OnEndDrag(PointerEventData eventData){
    
        
	}
    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("fdjsklaf");
    }
}

 