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
        
        // ステージ遷移回数をstageに代入
        stage = StartController.StageCount;

        StopCube = true;
        
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 現ステージを表示する
        stageText.text = "Stage " + stage.ToString();

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
