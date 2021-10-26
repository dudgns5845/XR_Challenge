using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinialScene_Rio : MonoBehaviour
{
    public void ReStart()
    {
        Destroy(WorkOutInfoManager_Rio.instance);
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
