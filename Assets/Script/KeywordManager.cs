using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeywordManager : MonoBehaviour
{


    public string[] var_name;
    public float[] var;

    public string[] switch_name;
    public bool[] switches;

    static public KeywordManager instance;
    public List<Keywords> KeywordsDB = new List<Keywords>();


    // Start is called before the first frame update
    void Start()
    {


    }
}
