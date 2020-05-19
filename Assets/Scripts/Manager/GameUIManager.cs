using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{

    public void StartMainUiLogic()
    {
        MainUI mainUI = FindObjectOfType<MainUI>();
        mainUI.UIInit();
    }
}
