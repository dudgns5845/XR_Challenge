using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WorkOutInfo
{
    
    public int idx;
    public string name;
    public string explain;
    public string tip;

    public WorkOutInfo(int idx , string name , string explain, string tip)
    {
        this.idx = idx;
        this.name = name;
        this.explain = explain;
        this.tip = tip;
    }

}


public class PrintWorkOutInfo_Rio : MonoBehaviour
{
    //void Start()
    //{
    //    List<Dictionary<string, object>> data = CSVReader.Read("WorkOutInfo");
    //    for(int i = 0; i < data.Count; i++)
    //    {
    //        print(data[i]["Name"].ToString() + " : " + data[i]["Explain"].ToString());
    //    }

    //}

    List<WorkOutInfo> info;

    //������� csv���� �о�� ��ü�� �����ϰ� ����Ʈ�� ����� �۾�
    private void Start()
    {
        //csv���� �о�ͼ�
        List<Dictionary<string, object>> data = CSVReader.Read("WorkOutInfo");
        //��ü �����ϱ�
        for (int i = 0; i < data.Count; i++)
        {
            int idx = int.Parse(data[i]["Number"].ToString());
            string name = data[i]["Name"].ToString();
            string explain = data[i]["Explain"].ToString();
            string tip = data[i]["Tip"].ToString();

            //print(name);
            info.Add( new WorkOutInfo(idx, name, explain, tip));
            //print(data[i]["Number"].ToString()+" : " + data[i]["Name"].ToString() + " : " + data[i]["Explain"].ToString() + " : "+ data[i]["Tip"].ToString());
            //info.Add(new WorkOutInfo(int.Parse(data[i]["Number"].ToString()), data[i]["Name"].ToString(), data[i]["Explain"].ToString(), data[i]["Tip"].ToString()));
        }

        //for(int i = 0; i < info.Count; i++)
        //{
        //    print(info[i].name);
        //}
    }


}
