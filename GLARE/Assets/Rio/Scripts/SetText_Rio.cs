using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText_Rio : MonoBehaviour
{
    public Narration_Rio Nar;

    private void Start()
    {
        Nar = GameObject.FindObjectOfType<Narration_Rio>();
        SetText(gameObject.name);
    }

    //자기 이름에 따라서 문자열을 가져간다.
    void SetText(string name)
    {
        if (name == "TXT_Name")
        {
            gameObject.GetComponent<Text>().text = WorkOutInfoManager_Rio.instance.chart.workOutChart[WorkOutInfoManager_Rio.instance.nowIndex].Name;
        }
        if (name == "TXT_Explain")
        {
            StartCoroutine(UpdateExplain());
        }
        if (name == "TXT_Tip")
        {
            gameObject.GetComponent<Text>().text = WorkOutInfoManager_Rio.instance.chart.workOutChart[WorkOutInfoManager_Rio.instance.nowIndex].Tip;
        }
    }

    //설명이 여러 개 일 수 있으므로
    IEnumerator UpdateExplain()
    {
        for(int i = 0; i < WorkOutInfoManager_Rio.instance.chart.workOutChart[WorkOutInfoManager_Rio.instance.nowIndex].Explain.Length; i++)
        {
            print(WorkOutInfoManager_Rio.instance.nowIndex + "_" + i);
            Nar.playExplain(WorkOutInfoManager_Rio.instance.nowIndex+"_"+i);
            gameObject.GetComponent<Text>().text = WorkOutInfoManager_Rio.instance.chart.workOutChart[WorkOutInfoManager_Rio.instance.nowIndex].Explain[i];
            yield return new WaitForSeconds(Nar.Player.clip.length+1);
        }
    }
}
