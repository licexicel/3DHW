using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameApplication : MonoBehaviour
{
    public GameSceneManager GSM;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        GameApplicationInit();
    }

    //所有管理初始化
    public void GameApplicationInit()
    {
        GSM = FindObjectOfType<GameSceneManager>();
        GSM.ChangeToMainUI();

    }

    public void GameApplicationQuit()
    {

    }
 
}
