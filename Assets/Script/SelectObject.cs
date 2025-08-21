using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectObject : MonoBehaviour, IPointerClickHandler
{
    public GameObject info;
    public GameObject keyPad;

    public Button closeBtn;
    public Button pwdBtn;

    public Text text_Keyword;
    public Text text_Description;
    public static bool isOpen;

    [SerializeField] string objectName;
    [SerializeField] string objectDescription;
    //public Button button1;

    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        info.SetActive(false);
        keyPad.SetActive(false);
        pwdBtn.gameObject.SetActive(false);
        closeBtn.onClick.AddListener(closeInfo);
    }
 
    void closeInfo()
    {
        info.SetActive(false);
    }

    /*public void Savedata()
    {
        PlayerPrefs.SetString("KeywordName", objectName);
        PlayerPrefs.SetString("KeywordDescription", objectDescription);
    }*/

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isOpen == false)
        {
            info.SetActive(true);
            
            GameObject clickObject = EventSystem.current.currentSelectedGameObject;
            if (objectName == "키패드Btn")
            {
                pwdBtn.gameObject.SetActive(true);
                pwdBtn.onClick.AddListener(showKey);
            }
            else
            {
                pwdBtn.gameObject.SetActive(false);
            }

            text_Keyword.text = objectName;
            text_Description.text = objectDescription;
        }
        
    }

    void showKey()
    {
        keyPad.SetActive(true);
        info.SetActive(false);
    }

    /*
    public void LoadKeywords()
    {
        if (PlayerPrefs.HasKey("KeywordName"))
        {
            text_Keyword.text = PlayerPrefs.GetString("KeywordName");
            text_Description.text = PlayerPrefs.GetString("KeywordDescription");

        }
    }
    */
}
