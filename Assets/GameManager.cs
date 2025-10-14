using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // ステージ
    public static int stage = 1;

    // ステージ数を表示させるための変数
    public Text stageText;

    // 障害物を止めたか管理する変数
    public static bool StopCube = true;

    // Start is called before the first frame update
    void Start()
    {
        //stage = 1;

        // 前回の続き
        // NextStageにstageを合わせる
        // ゲーム画面を読み込む度にカウントを増やし、スタート画面から読み込んだらカウントを1に戻す処理が必要

        //if (NextButtonController.NextStage == 1)
        //{
        //    stage = 1;
        //}
        //else if (NextButtonController.NextStage > 1)
        //{
        //    // NextStageの値を受け取る
        //    stage = NextButtonController.NextStage;
        //}
        
        // ステージ遷移回数をstageに代入
        stage = StartController.StageCount;


        //stage = 5;
        //if (!StartController.New)
        //{
        //    stage = 1;
        //}

        StopCube = true;
        
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 現ステージを表示する
        stageText.text = "Stage " + stage.ToString();

        Debug.Log(NextButtonController.NextStage);
        Debug.Log(stage);

        // 障害物の止めた数を管理する
        // それぞれフラグが立ったら他の障害物を止められないようにする
        if (!CubeContorller.CubeFlag || !HoleCubeController.CubeHoleFlag || !HoleController.HoleFlag || !WallController.WallFlag)
        {
            StopCube = false;
        }
        // フラグがなくなったらまた止められるようにする
        else if (CubeContorller.CubeFlag || HoleCubeController.CubeHoleFlag || HoleController.HoleFlag || WallController.WallFlag)
        {
            StopCube = true;
        }
    }
}
