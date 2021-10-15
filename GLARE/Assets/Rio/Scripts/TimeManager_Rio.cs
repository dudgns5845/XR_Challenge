using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TimeManager_Rio : MonoBehaviour
{
    public static TimeManager_Rio instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }

    public string AllDate = DateTime.Now.ToString("yyyy≥‚ MM dd¿œ dddd");
    public string singleDate = DateTime.Now.ToString("dddd");
}
