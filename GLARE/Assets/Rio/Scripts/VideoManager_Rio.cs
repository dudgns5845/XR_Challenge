using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager_Rio : MonoBehaviour
{
    //영상이 보여지는 곳
    public List<GameObject> VideoView;
    public List<VideoClip> VideoClip;
    //재생 정지를 담당하는 곳
    public VideoPlayer player;

    //현재 비디오 인덱스
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
