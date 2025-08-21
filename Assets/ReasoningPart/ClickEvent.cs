using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour, IPointerClickHandler
{
    public GameObject Detail;
    Vector2 ori;
    
    private float currentClick;
    public Button btn;

    public void Start()
    {
        ori = Detail.transform.position;
        btn.onClick.AddListener(Closed);

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        currentClick = eventData.clickCount;

        if (currentClick >= 2)
        {
            Detail.transform.position = new Vector2(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);        

        }
    }
 
    public void Closed()
    {
        Detail.transform.position = ori;
    }
}
