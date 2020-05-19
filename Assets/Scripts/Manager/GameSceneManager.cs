using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManager : MonoBehaviour
{

       public void ChangeToMainUI()
        {
            Debug.Log("CHANGE");
            GameUIManager GUI = FindObjectOfType<GameUIManager>();
            SceneManager.LoadScene("MainUI");
            GUI.StartMainUiLogic();
        }
}
