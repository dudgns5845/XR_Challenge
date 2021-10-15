using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartExercise_Rio : MonoBehaviour
{
    //진행Bar
    public Image ProgressBar;
    //Bar 값 변수
    float nowProgress = 0;
    //운동 시간
    public float SetTime = 120f;

    public VideoPlayer video;

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
                Ready();
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

    void Ready()
    {
        video.Stop();
    }

    void exe_Start()
    {
        video.Play();
        nowProgress += Time.deltaTime;
        ProgressBar.fillAmount = nowProgress / SetTime;
        if(ProgressBar.fillAmount >= 1)
        {
            if(WorkOutInfoManager_Rio.instance.WorkOutindexList_idx == WorkOutInfoManager_Rio.instance.chart.workOutChart.Count)
            {
                SceneManager.LoadScene(0);
                return;
            }
            WorkOutInfoManager_Rio.instance.nowIndexUpdate();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
