using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class HoleCubeController : MonoBehaviour
{
    // マテリアル変更用
    [SerializeField] Material mat = default;
    [SerializeField] Material mat2 = default;

    // ブロックの動き方を管理する変数
    public float HoleCubeNum = 0;

    // 動きの切り替え用変数
    bool move = true;

    // マウスの止める切り替え変数
    bool moveFlag = true;

    // 止めたブロックの制限変数
    public static bool CubeHoleFlag = true;

    public GameObject ClickSE;
    
    // Start is called before the first frame update
    void Start()
    {
        CubeHoleFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        Vector3 worldAngle = myTransform.eulerAngles;


        if (moveFlag)
        {
            // ブロックの動きを分ける
            switch (HoleCubeNum)
            {
                // 2ステ
                case 2.1f:

                    worldAngle.y += 4;

                    myTransform.eulerAngles = worldAngle;

                    break;

                // 3ステ
                case 3.1f:

                    worldAngle.y += 4;

                    myTransform.eulerAngles = worldAngle;

                    break;


            }
        }
    }
    // マウスが当たっていたら
    public void DontMoveHoleCube()
    {
        // 上視点のみ
        if (!MainCameraController.eye)
        {
            // 全ての障害物が止まっていなかったら
            if (GameManager.StopCube)
            {
                // この障害物が止まっていなかったら
                if (moveFlag)
                {
                    // 左クリックしたら止める
                    if (Input.GetMouseButtonDown(0))
                    {
                        Instantiate(ClickSE);
                        moveFlag = false;
                        CubeHoleFlag = false;
                        this.GetComponent<MeshRenderer>().material = mat;
                    }
                }
            }
            // どれか1つの障害物が止まっていたら
            if (!GameManager.StopCube)
            {
                // その障害物がこれだったら
                if (!moveFlag)
                {
                    // 左クリックしたら動かす
                    if (Input.GetMouseButtonDown(0))
                    {
                        Instantiate(ClickSE);
                        moveFlag = true;
                        CubeHoleFlag = true;
                        this.GetComponent<MeshRenderer>().material = mat2;
                    }
                }
            }
        }
    }
}
