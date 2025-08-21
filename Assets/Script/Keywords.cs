using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Keywords
{
    public int KeyId;
    public string KeyName;
    public string KeyDes;
    public int KeyTC;
    public int KeyActive;

    public Keywords(int _KeyId, string _KeyName, string _KeyDes, int _KeyTC = 0, int _KeyActive = 0)
    {
        KeyId = _KeyId;
        KeyName = _KeyName;
        KeyDes = _KeyDes;
        KeyTC = _KeyTC;
        KeyActive = _KeyActive;
    }

        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
        {
            KeyTC++;
        }

        if (KeyTC == 0)
        {
            KeyActive = 0;
        }

        else
        {
            KeyActive = 1;
        }


        }
}
