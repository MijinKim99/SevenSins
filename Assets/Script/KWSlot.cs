using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KWSlot : MonoBehaviour
{
    public Text kwName_text;
    public Text kwDes_text;
    public int kwTC_int;
    public int kwActive_int;
    public GameObject selected_kw;

    public void AddKeyword(Keywords _Keyword)
    {
        kwName_text.text = _Keyword.KeyName;

        if(_Keyword.KeyActive != 0)
        {
            selected_kw.SetActive(true);
        }

        else if(_Keyword.KeyActive == 0)
        {
            selected_kw.SetActive(false);
        }
    }
}
