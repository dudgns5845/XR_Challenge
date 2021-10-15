using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Video;

public class WorkOutInfoManager_Rio : MonoBehaviour
{
    //singletone
    public static WorkOutInfoManager_Rio instance;
    //json�ֻ��� ��ü-> chart.workOutChart[idx].�ε�����
    public WorkOutChart chart;

    //������ � �ε��� ����Ʈ
    public List<int> WorkOutindexList;
    public int WorkOutindexList_idx;

    //���� � ���
    public int nowIndex;

   
    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
            //��� �������� �ȵ�
        }else if(instance != null)
        {
            Destroy(this);
        }

        //jsonData�о����
        ReadJson();

        nowIndexUpdate();
    }


    void ReadJson()
    {
        TextAsset textAsset = Resources.Load("WorkOutInfoJson") as TextAsset;

        //string path = Application.dataPath + "/Resources/WorkOutInfoJson.json";
        //string data = File.ReadAllText(path);
        string data = textAsset.ToString();
        chart = new WorkOutChart();
        chart = JsonUtility.FromJson<WorkOutChart>(data);
    }

    public void nowIndexUpdate()
    {
        nowIndex = WorkOutindexList[WorkOutindexList_idx++] - 1;
    }
}

[System.Serializable]
public class WorkOutChart
{
    public List<WorkOutInfomation> workOutChart;
}

[System.Serializable]
public class WorkOutInfomation
{
    public int Number;
    public string Name;
    public string[] Explain;
    public string Tip;
}
