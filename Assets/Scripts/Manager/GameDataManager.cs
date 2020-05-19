using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    /// <summary>
    /// 開始遊戲需要的資料
    /// </summary>
    public static GameFlowData FlowData { get; set; }

    /// <summary>
    /// 遊戲裡讀取設定
    /// </summary>
    public StageSetting NowStageSetting { get; set; }

}
