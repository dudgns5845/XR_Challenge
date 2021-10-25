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
        //TXT_Date = GameObject.Find("TXT_Date").GetComponent<Text>();
        //TXT_Time = GameObject.Find("TXT_Time").GetComponent<Text>();
        TXT_Date.text = DateTime.Now.ToString("yyyy년 MM월 dd일") + "\n" + DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("HH :mm");
        TXT_Time.text = DateTime.Now.ToString("yyyy년 MM월 dd일") + "\n" + DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("HH :mm");
        //TXT_Time.text = DateTime.Now.ToString("HH :mm");
    }

    private void Update()
    {
        UpdateTime();
    }
 
    void UpdateTime()
    {
        //TXT_Date.text = DateTime.Now.ToString("yyyy년 MM월 dd일") + "\n" + DateTime.Now.ToString("dddd");
        //TXT_Time.text = DateTime.Now.ToString("HH :mm");
    }


}
