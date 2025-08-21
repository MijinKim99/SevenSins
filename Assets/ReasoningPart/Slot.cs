using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public bool check;
    public GameObject PieceSet;

    public void OnDrop(PointerEventData eventData)
    {


        if (transform.childCount > 0)
        {
            transform.GetChild(0).gameObject.transform.position = transform.GetChild(0).gameObject.GetComponent<Drag>().initPos;
            transform.GetChild(0).gameObject.transform.SetParent(PieceSet.transform);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.transform.SetParent(transform);
        }
        else 
        {  

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.transform.SetParent(transform);        

        }  
        
        switch (eventData.pointerDrag.GetComponent<Drag>().id)
        {
            case 0:
            case 1:
            case 2:
                check = true;
                break;
            default:
                check = false;
                break;

        }
    }
   
}
