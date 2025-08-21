using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenKeyPad : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject notebook;
    public GameObject notebook1;
    public GameObject keyPadText;
    public Button btn;
    public Button closeBtn;

    void Start()
    {
        notebook1.SetActive(false);
        keyPadText.SetActive(false);
        btn.onClick.AddListener(showKey);
    }

    // Update is called once per frame
    void showKey()
    {
        keyPadText.SetActive(true);
        notebook.SetActive(false);
    }

    public void Exit()
    {
        notebook.SetActive(false);
    }

    public void Exit1()
    {
        notebook1.SetActive(false);
    }
}
