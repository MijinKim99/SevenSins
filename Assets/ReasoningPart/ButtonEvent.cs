using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonEvent : MonoBehaviour
{
    public GameObject Pos0, Pos1, Pos2;
    

    public void isClear()
    {
        if(Pos0.GetComponent<Slot>().check && Pos1.GetComponent<Slot>().check&& Pos2.GetComponent<Slot>().check == true)
        {
            Debug.Log("Full");
            //??????
        }
        else
        {
            Debug.Log("empty");
            //????????
        }
      
    }
}
