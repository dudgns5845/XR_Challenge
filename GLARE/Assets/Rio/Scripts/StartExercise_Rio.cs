using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartExercise_Rio : MonoBehaviour
{
    //진행Bar
    public Image ProgressBar;
    //Bar 값 변수
    float nowProgress = 0;
    //운동 시간
    public float SetTime = 120f;

    //상태 변수
    public State m_State = State.READY;
    
    public enum State
    {
        READY,
        START,
        PAUSE,
        END
    }

    // Update is called once per frame
    void Update()
    {
        switch (m_State)
        {
            case State.READY:
                break;
            case State.START:
                exe_Start();
                break;
            case State.END:
                break;
            case State.PAUSE:
                break;
        }   
    }

    void exe_Start()
    {
        nowProgress += Time.deltaTime;
        ProgressBar.fillAmount = nowProgress / 100;
    }
}
