using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    // マテリアル変更用
    [SerializeField] Material mat = default;
    [SerializeField] Material mat2 = default;

    // ブロックの動き方を管理する変数
    public float PlacementNumber = 0;

    // マウスの止める切り替え変数
    bool moveFlag = true;

    // 止めたブロックの制限変数
    public static bool WallFlag = true;

    public GameObject ClickSE;

    // Start is called before the first frame update
    void Start()
    {
        WallFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        Vector3 worldAngle = myTransform.eulerAngles;

        if (moveFlag)
        {
            // ブロックの動きを分ける
            switch (PlacementNumber)
            {


                // 6ステ
                case 6.1f:

                    worldAngle.y += 4f;

                    myTransform.eulerAngles = worldAngle;

                    break;


            }
        }
    }
    // マウスが当たっていたら
    public void DontMoveWall()
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
                        WallFlag = false;
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
                        WallFlag = true;
                        this.GetComponent<MeshRenderer>().material = mat2;
                    }
                }
            }
        }
    }
}
