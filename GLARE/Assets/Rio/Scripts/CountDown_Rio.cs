using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown_Rio : MonoBehaviour
{
    public StartExercise_Rio StartExercise_Rio;

    Text TXT_CountDown;

    AudioSource player;
    public List<AudioClip> EFT_Clips;
    private void Start()
    {
        player = GetComponent<AudioSource>();
        TXT_CountDown = GetComponent<Text>();
        StartCoroutine(CountDown());
    }
    
    IEnumerator CountDown()
    {
        AudioClip clip = EFT_Clips[0];
        
        player.PlayOneShot(clip);
        TXT_CountDown.text = "3";
        yield return new WaitForSeconds(1f);

        player.PlayOneShot(clip);
        TXT_CountDown.text = "2";
        yield return new WaitForSeconds(1f);

        player.PlayOneShot(clip);
        TXT_CountDown.text = "1";
        yield return new WaitForSeconds(1f);

        clip = EFT_Clips[1];
        player.PlayOneShot(clip);
        TXT_CountDown.fontSize = 130;
        TXT_CountDown.text = "START!";
        yield return new WaitForSeconds(2f);

        TXT_CountDown.gameObject.SetActive(false);

        StartExercise_Rio.m_State = StartExercise_Rio.State.START;

    }

}
