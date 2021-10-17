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

    //�ڱ� �̸��� ���� ���ڿ��� ��������.
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

    //������ ���� �� �� �� �����Ƿ�
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
