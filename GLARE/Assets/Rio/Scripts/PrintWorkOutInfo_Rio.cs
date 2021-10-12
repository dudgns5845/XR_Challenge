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

    //������� csv���� �о�� ��ü�� �����ϰ� ����Ʈ�� ����� �۾�
    private void Start()
    {
        info = new List<WorkOutInfo>();
        //csv���� �о�ͼ�
        List<Dictionary<string, object>> data = CSVReader.Read("WorkOutInfo");
        //��ü �����ϱ�
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
