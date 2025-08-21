using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyPad : MonoBehaviour
{
    public GameObject SuccessBtn;
    public GameObject SuccessBtn2;
    public GameObject Notebook;
    public GameObject keypad08;

   
    //public GameObject hud;
    //public GameObject inv;

  
    //public Animator ANI;

    public Text text08;
    public string answer = "1326324";
    public int a = 0;

    //public AudioSource button;
    public AudioSource doorOpen;
    public AudioSource wrong;

 

    private void Start()
    {
        SuccessBtn = GameObject.Find("사업 서류1");
        SuccessBtn2 = GameObject.Find("노트북1");
        Notebook = GameObject.Find("노트북Btn");
    }

    public void Number(int number)
    {
        //button.Play();
        if (text08.text.Length < 7)
        {
            text08.text += number.ToString();
        }
    }

    public void Execute()
    {
        if(text08.text==answer)
        {
            doorOpen.Play();
            text08.text = "";
            a = 1;
            if (gameObject.name == "노트북Btn")
            {
                SuccessBtn.SetActive(true);
                SuccessBtn2.SetActive(true);
            }

            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            Debug.Log("right");
        }
        else
        {
            wrong.Play();
            text08.text = "";
            Debug.Log("wrong");
        }
    }

    public void Delete()
    {
        text08.text = text08.text.Substring(0,text08.text.Length-1);
        //button.Play();
    }

    public void Exit()
    {
        keypad08.SetActive(false);
       
        //inv.SetActive(true);
        //hud.SetActive(true);
        
    }

    public void Update()
    {
        if (a==1)
        {
            keypad08.SetActive(false);
            SelectObject.isOpen = true;
            
        }
    }



}
