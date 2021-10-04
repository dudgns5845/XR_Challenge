using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartExercise_Rio : MonoBehaviour
{
    //����Bar
    public Image ProgressBar;
    //Bar �� ����
    float nowProgress = 0;
    //� �ð�
    public float SetTime = 120f;

    public VideoPlayer video;

    //���� ����
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
        ProgressBar.fillAmount = nowProgress / 100;
    }
}