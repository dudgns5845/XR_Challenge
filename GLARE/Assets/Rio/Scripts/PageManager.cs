using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    public List<GameObject> Canvas;
    int Canvasindex = 0;
    //다음페이지로 이동하는 것
    public void NextPage(int index)
    {
        StartCoroutine(Wait(index));
    }

    IEnumerator Wait(int index)
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(index);
    }

    //운동실행 시 다음 장면으로 넘어가는 함수
    public void NextCanvas(int index)
    {

        Canvas[Canvasindex].SetActive(false);
        Canvasindex += 1;
        Canvas[Canvasindex].SetActive(true);
    }

    
}
