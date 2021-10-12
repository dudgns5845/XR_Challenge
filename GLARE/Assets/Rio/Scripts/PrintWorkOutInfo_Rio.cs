using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
class WorkOutInfo
{
    public int idx;
    public string name;
    public string explain;
    public string tip;

    public WorkOutInfo(int idx, string name, string explain, string tip)
    {
        this.idx = idx;
        this.name = name;
        this.explain = explain;
        this.tip = tip;
    }
}

[System.Serializable]
class JsonArrayData
{
    public List<WorkOutInfo> d;
}


public class PrintWorkOutInfo_Rio : MonoBehaviour
{
    WorkOutInfo aa;
    List<WorkOutInfo> info;

    //운동정보를 csv에서 읽어와 객체에 저장하고 리스트를 만드는 작업
    private void Start()
    {
        info = new List<WorkOutInfo>();
        //csv에서 읽어와서
        List<Dictionary<string, object>> data = CSVReader.Read("WorkOutInfo");
        //객체 생성하기
        for (int i = 0; i < data.Count; i++)
        {
            int idx = 0;//int.Parse(data[i]["Number"].ToString());
            string name = data[i]["Name"].ToString();
            string explain = data[i]["Explain"].ToString();
            string tip = data[i]["Tip"].ToString();

            info.Add(new WorkOutInfo(idx, name, explain, tip));
        }
        JsonArrayData jsonData = new JsonArrayData();
        jsonData.d = info;
        string jsonString = JsonUtility.ToJson(jsonData, true);
        print(jsonString);
    }
}
