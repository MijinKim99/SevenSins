using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyPad1 : MonoBehaviour
{

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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

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
