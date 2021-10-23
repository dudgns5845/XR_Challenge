using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorkOutAnimation_Rio : MonoBehaviour
{
    //���� ī��Ʈ �ٿ��� ������
    //idle ->�ش� � �ִϸ��̼��� ����
    //Ʈ���Ŵ� �ѹ��� �ߵ��ϸ� ��
    bool isStart = false;
    Animator animator;
    StartExercise_Rio state;

    private void Start()
    {
        animator = GetComponent<Animator>();
        state = GameObject.FindObjectOfType<StartExercise_Rio>().GetComponent<StartExercise_Rio>();
    }

    private void Update()
    {

        //���۽�ȣ�� ������
        if (state.m_State == StartExercise_Rio.State.START)
        {
            //���۾�������
            if(isStart == false)
            {
                animator.SetTrigger((WorkOutInfoManager_Rio.instance.nowIndex+1).ToString());
                isStart = true;
            }
            //����������
            else
            {
                return;
            }
        }


    }


}
