using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStarter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("Canvas").transform.Find("Dialogue00").gameObject.SetActive(true);
        }
     
    }
}
