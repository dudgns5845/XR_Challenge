using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
    
    //������������ �̵��ϴ� ��
    public void NextPage()
    {
        //int nextPage = SceneManager.GetActiveScene().buildIndex+1;
        //SceneManager.LoadScene(nextPage);
        SceneManager.LoadScene("Scene_01_Info");
    }
}
