using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager_Rio : MonoBehaviour
{
    public static SoundManager_Rio manager;

    public AudioSource BGM_player;
    public AudioSource EFT_player;

    public List<AudioClip> BGM_clips;
    public List<AudioClip> EFT_clips;

    private void Awake()
    {
        //DontDestroyOnLoad(this);
        if (manager == null)
        {
            manager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        if (!BGM_player.isPlaying)
        {
            BGM_Play(0);

        }
    }
    public void BGM_Play(int index)
    {
        BGM_player.clip = BGM_clips[index];
        BGM_player.Play();
    }

    //0버튼클릭
    public void EFT_Play(int index)
    {
        print("출력");
        EFT_player.PlayOneShot(EFT_clips[index]);
    }
}
