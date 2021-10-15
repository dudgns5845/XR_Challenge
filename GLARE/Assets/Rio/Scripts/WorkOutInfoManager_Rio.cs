using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Video;

public class WorkOutInfoManager_Rio : MonoBehaviour
{
    //singletone
    public static WorkOutInfoManager_Rio instance;
    //json최상위 객체-> chart.workOutChart[idx].인덱스명
    public WorkOutChart chart;

    //오늘의 운동 인덱스 리스트
    public List<int> WorkOutindexList;
    public int WorkOutindexList_idx;

    //현재 운동 목록
    public int nowIndex;

   
    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;
            //얘는 없어지면 안됨
        }else if(instance != null)
        {
            Destroy(this);
        }

        //jsonData읽어오기
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
