using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
    public List<GameObject> Canvas;
    int Canvasindex = 0;
    //������������ �̵��ϴ� ��
    public void NextPage(int index)
    {
        StartCoroutine(Wait(index));
    }

    //����� �� ���� ������� �Ѿ�� �Լ�
    public void NextCanvas(int index)
    {

        Canvas[Canvasindex].SetActive(false);
        Canvasindex += 1;
        Canvas[Canvasindex].SetActive(true);
    }

    IEnumerator Wait(int index)
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(index);
    }

   

}
