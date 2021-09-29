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
    public int index;

    public void VideoPlay()
    {
        player.clip = VideoClip[index];
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
