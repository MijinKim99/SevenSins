using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour,IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    private RectTransform rectTrans;
    public Canvas canv;
    private CanvasGroup canvgroup;
    public int id;
   
    public Vector2 initPos;



    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvgroup = GetComponent<CanvasGroup>();
        initPos = transform.position; 

    }
    
 

    public void OnBeginDrag(PointerEventData eventData)
    {
       
         canvgroup.blocksRaycasts = false;
        

    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTrans.anchoredPosition += eventData.delta/canv.scaleFactor;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvgroup.blocksRaycasts = true;


    }

  
  
}
