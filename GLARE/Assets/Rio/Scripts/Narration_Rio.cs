using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration_Rio : MonoBehaviour
{
    static public Narration_Rio instance;

    public List<AudioClip> Explain_clips;
    public List<AudioClip> Tip_clips;

    public AudioSource Player;

    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    public void playExplain(string index)
    {
        AudioClip clip = Explain_clips.Find(x => x.name == index);
        print(clip.name);
        Player.clip = clip;
        Player.Play();
    }

    public void playTip(string index)
    {
        AudioClip clip = Tip_clips.Find(x => x.name == index);
        Player.clip = clip;
        Player.Play();
    }

    public void Stop_Nar()
    {
        Player.Stop();
    }
}
