using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintWorkOutInfo_Rio : MonoBehaviour
{
    void Start()
    {
        List<Dictionary<string, object>> data = CSVReader.Read("WorkOutInfo");
        for(int i = 0; i < data.Count; i++)
        {
            print(data[i]["Name"].ToString() + " : " + data[i]["Explain"].ToString());
        }
    }


}
