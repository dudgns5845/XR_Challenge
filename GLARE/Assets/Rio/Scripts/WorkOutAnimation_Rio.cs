using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorkOutAnimation_Rio : MonoBehaviour
{
    //시작 카운트 다운이 끝나면
    //idle ->해당 운동 애니메이션을 실행
    //트리거는 한번만 발동하면 됨
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

        //시작신호가 없으면
        if (state.m_State == StartExercise_Rio.State.START)
        {
            //시작안했으면
            if(isStart == false)
            {
                animator.SetTrigger((WorkOutInfoManager_Rio.instance.nowIndex+1).ToString());
                isStart = true;
            }
            //시작했으면
            else
            {
                return;
            }
        }


    }


}
