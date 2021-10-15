using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText_Rio : MonoBehaviour
{
    private void Start()
    {
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
            gameObject.GetComponent<Text>().text = WorkOutInfoManager_Rio.instance.chart.workOutChart[WorkOutInfoManager_Rio.instance.nowIndex].Explain[i];
            yield return new WaitForSeconds(2f);
        }
    }
}
