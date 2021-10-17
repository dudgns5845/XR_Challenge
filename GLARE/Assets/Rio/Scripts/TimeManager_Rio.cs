using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeManager_Rio : MonoBehaviour
{
    public static TimeManager_Rio instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }


    //string AllDate;
    //string singleDate;

    public Text TXT_Date;
    public Text TXT_Time;

    private void Start()
    {
        TXT_Date = GameObject.Find("TXT_Date").GetComponent<Text>();
        TXT_Time = GameObject.Find("TXT_Time").GetComponent<Text>();
    }

    private void Update()
    {
        UpdateTime();
    }
 
    void UpdateTime()
    {
        //TXT_Date.text = DateTime.Now.ToString("yyyy³â MM¿ù ddÀÏ") + "\n" + DateTime.Now.ToString("dddd");
        //TXT_Time.text = DateTime.Now.ToString("HH :mm");
    }


}
