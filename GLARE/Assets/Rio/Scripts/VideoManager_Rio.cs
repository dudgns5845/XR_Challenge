using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager_Rio : MonoBehaviour
{
    //������ �������� ��
    public List<GameObject> VideoView;
    public List<VideoClip> VideoClip;
    //��� ������ ����ϴ� ��
    public VideoPlayer player;

    //���� ���� �ε���
    //public int index;

    private void Start()
    {
        VideoPlay();
        print(WorkOutInfoManager_Rio.instance.WorkOutindexList_idx-1);
    }

    public void VideoPlay()
    {
        //player.clip = VideoClip[index];
        player.clip = VideoClip[WorkOutInfoManager_Rio.instance.WorkOutindexList_idx-1];
        player.Play();
    }

    public void VideoPause()
    {
        player.Pause();
    }

    public void VideoRestart()
    {
        player.time = 0f;
    }

    
}
