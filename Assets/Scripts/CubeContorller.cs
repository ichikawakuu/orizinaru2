using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CubeContorller : MonoBehaviour
{
    // マテリアル変更用
    [SerializeField] Material mat = default;
    [SerializeField] Material mat2 = default;

    RaycastHit hit;
    GameObject targetObject;
    // ブロックの動き方を管理する変数
    public float CubeNum = 0;

    // x軸の動きの切り替え用変数
    bool moveX = true;

    // z軸の動きの切り替え用変数
    bool moveZ = true;

    // x軸の動きを止める変数
    bool StopMoveX = true;

    // z軸の動きを止める変数
    bool StopMoveZ = true;

    // マウスの止める切り替え変数
    bool moveFlag = true;

    // 止めたブロックの制限変数
    public static bool CubeFlag = true;

    public GameObject ClickSE;

    // Start is called before the first frame update
    void Start()
    {
        CubeFlag = true;


        switch (CubeNum)
        {
            case 4.1f:

                // x軸の動きを止める
                StopMoveX = false;

                break;

            case 4.2f:

                // x軸の動きを止める
                StopMoveX = false;

                break;

            case 4.3f:

                // x軸の動きを止める
                StopMoveX = false;

                break;

            case 4.4f:

                // z軸の動きを止める
                StopMoveZ = false;

                break;

            case 6.1f:

                // x軸の動きを止める
                StopMoveX = false;

                break;

            case 6.2f:

                // x軸の動きを止める
                StopMoveX = false;

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        if (moveFlag)
        {

            // ブロックの動きを分ける
            switch (CubeNum)
            {

                // ルール
                case 0.1f:

                    // 縦軸移動 x→y
                    // 横軸移動 z→x

                    if (pos.y < 2)
                    {
                        moveX = true;
                    }
                    else if (pos.y > 3)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.y += 0.05f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.y -= 0.05f;

                        myTransform.position = pos;
                    }


                    break;

                // 1ステ
                case 1.1f:

                    if (pos.x < 19)
                    {
                        moveX = true;
                    }
                    else if (pos.x > 21)
                    {
                        moveX = false;
                    }
                    
                    if (moveX)
                    {
                        pos.x += 0.1f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x -= 0.1f;

                        myTransform.position = pos;
                    }
                    

                    break;
                // 2ステ下
                case 2.1f:

                    if (pos.x < 0.3)
                    {
                        moveX = true;
                    }
                    else if (pos.x > 0.5)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.x += 0.008f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x -= 0.008f;

                        myTransform.position = pos;
                    }
                    break;

                // 2ステ上
                case 2.2f:

                    if (pos.x > -0.3)
                    {
                        moveX = true;
                    }
                    else if (pos.x < -0.5)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.x -= 0.008f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x += 0.008f;

                        myTransform.position = pos;
                    }

                    break;

                // 3ステ左
                case 3.1f:

                    if (pos.x < 39)
                    {
                        moveX = true;
                    }
                    else if (pos.x > 41)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.x += 0.05f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x -= 0.05f;

                        myTransform.position = pos;
                    }

                    break;

                // 3ステ真ん中
                case 3.2f:

                    if (pos.x < 39)
                    {
                        moveX = true;
                    }
                    else if (pos.x > 41)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.x += 0.05f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x -= 0.05f;

                        myTransform.position = pos;
                    }

                    break;

                // 3ステ右
                case 3.3f:

                    if (pos.x < 39)
                    {
                        moveX = true;
                    }
                    else if (pos.x > 41)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.x += 0.05f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x -= 0.05f;

                        myTransform.position = pos;
                    }

                    break;

                // 4ステ真ん中
                case 4.1f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 0.3)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
                            Debug.Log("超えたよ");
                        }
                        else if (pos.z < -0.3)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = false;
                        }
                    }
                    // x軸の移動
                    else if (StopMoveX)
                    {
                        if (pos.x > 80.3)
                        {
                            Debug.Log(StopMoveZ);
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = false;
                            
                        }
                        else if (pos.x < 79.7)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = true;
                        }
                    }

                    // z軸を動かすなら
                    if (StopMoveZ)
                    {
                        if (moveZ)
                        {
                            pos.z += 0.01f;

                            myTransform.position = pos;
                        }
                        else if (!moveZ)
                        {
                            pos.z -= 0.01f;

                            myTransform.position = pos;
                        }
                    }
                    // x軸を動かすなら
                    if (StopMoveX)
                    {
                        if (moveX)
                        {
                            pos.x += 0.01f;

                            myTransform.position = pos;
                        }
                        else if (!moveX)
                        {
                            pos.x -= 0.01f;

                            myTransform.position = pos;
                        }
                    }

                    break;

                case 4.2f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > -1.2)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
                            Debug.Log("超えたよ");
                        }
                        else if (pos.z < -1.8)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = false;
                        }
                    }
                    // x軸の移動
                    else if (StopMoveX)
                    {
                        if (pos.x > 80.6)
                        {
                            Debug.Log(StopMoveZ);
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = false;

                        }
                        else if (pos.x < 80)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = true;
                        }
                    }

                    // z軸を動かすなら
                    if (StopMoveZ)
                    {
                        if (moveZ)
                        {
                            pos.z += 0.05f;

                            myTransform.position = pos;
                        }
                        else if (!moveZ)
                        {
                            pos.z -= 0.05f;

                            myTransform.position = pos;
                        }
                    }
                    // x軸を動かすなら
                    if (StopMoveX)
                    {
                        if (moveX)
                        {
                            pos.x += 0.05f;

                            myTransform.position = pos;
                        }
                        else if (!moveX)
                        {
                            pos.x -= 0.05f;

                            myTransform.position = pos;
                        }
                    }

                    break;

                case 4.3f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 1.8)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
                            Debug.Log("超えたよ");
                        }
                        else if (pos.z < 1.2)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = false;
                        }
                    }
                    // x軸の移動
                    else if (StopMoveX)
                    {
                        if (pos.x > 80)
                        {
                            Debug.Log(StopMoveZ);
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = false;

                        }
                        else if (pos.x < 79.4)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = true;
                        }
                    }

                    // z軸を動かすなら
                    if (StopMoveZ)
                    {
                        if (moveZ)
                        {
                            pos.z += 0.05f;

                            myTransform.position = pos;
                        }
                        else if (!moveZ)
                        {
                            pos.z -= 0.05f;

                            myTransform.position = pos;
                        }
                    }
                    // x軸を動かすなら
                    if (StopMoveX)
                    {
                        if (moveX)
                        {
                            pos.x += 0.05f;

                            myTransform.position = pos;
                        }
                        else if (!moveX)
                        {
                            pos.x -= 0.05f;

                            myTransform.position = pos;
                        }
                    }

                    break;

                case 4.4f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 3)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
                            Debug.Log("超えたよ");
                        }
                        else if (pos.z < -3)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = false;
                        }
                    }
                    // x軸の移動
                    else if (StopMoveX)
                    {
                        if (pos.x > 81.5f)
                        {
                            Debug.Log(StopMoveZ);
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = false;

                        }
                        else if (pos.x < 78.5f)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = true;
                        }
                    }

                    // z軸を動かすなら
                    if (StopMoveZ)
                    {
                        if (moveZ)
                        {
                            pos.z += 0.1f;

                            myTransform.position = pos;
                        }
                        else if (!moveZ)
                        {
                            pos.z -= 0.1f;

                            myTransform.position = pos;
                        }
                    }
                    // x軸を動かすなら
                    if (StopMoveX)
                    {
                        if (moveX)
                        {
                            pos.x += 0.1f;

                            myTransform.position = pos;
                        }
                        else if (!moveX)
                        {
                            pos.x -= 0.1f;

                            myTransform.position = pos;
                        }
                    }

                    break;

                // 5ステ
                case 5.1f:

                    if (pos.x < 99)
                    {
                        moveX = true;
                    }
                    else if (pos.x > 101)
                    {
                        moveX = false;
                    }

                    if (moveX)
                    {
                        pos.x += 0.05f;

                        myTransform.position = pos;
                    }
                    else if (!moveX)
                    {
                        pos.x -= 0.05f;

                        myTransform.position = pos;
                    }

                    break;

                case 6.1f:
                    
                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 1)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
                        }
                        if (pos.z < -1)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = false;
                        }
                    }
                    // x軸の移動
                    else if (StopMoveX)
                    {
                        if (pos.x > 61)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = false;
                        }
                        else if (pos.x < 59)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = true;
                        }
                    }

                    // z軸を動かすなら
                    if (StopMoveZ)
                    {
                        if (moveZ)
                        {
                            pos.z += 0.05f;

                            myTransform.position = pos;
                        }
                        else if (!moveZ)
                        {
                            pos.z -= 0.05f;

                            myTransform.position = pos;
                        }
                    }
                    // x軸を動かすなら
                    if (StopMoveX)
                    {
                        if (moveX)
                        {
                            pos.x += 0.05f;

                            myTransform.position = pos;
                        }
                        else if (!moveX)
                        {
                            pos.x -= 0.05f;

                            myTransform.position = pos;
                        }
                    }

                    break;

                case 6.2f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 2)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = false;
                        }
                        if (pos.z < -2)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
                        }
                    }
                    // x軸の移動
                    else if (StopMoveX)
                    {
                        if (pos.x > 62)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = true;
                        }
                        else if (pos.x < 58)
                        {
                            StopMoveX = false;
                            StopMoveZ = true;
                            moveZ = false;
                        }
                    }

                    // z軸を動かすなら
                    if (StopMoveZ)
                    {
                        if (moveZ)
                        {
                            pos.z += 0.1f;

                            myTransform.position = pos;
                        }
                        else if (!moveZ)
                        {
                            pos.z -= 0.1f;

                            myTransform.position = pos;
                        }
                    }
                    // x軸を動かすなら
                    if (StopMoveX)
                    {
                        if (moveX)
                        {
                            pos.x += 0.1f;

                            myTransform.position = pos;
                        }
                        else if (!moveX)
                        {
                            pos.x -= 0.1f;

                            myTransform.position = pos;
                        }
                    }

                    break;

            }


        }


    }

    // マウスが当たっていたら
    public void DontMoveCube()
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
                        CubeFlag = false;
                        this.GetComponent<MeshRenderer>().material = mat;
                    }
                }
            }
            // どれか1つの障害物が止まっていたら
            else if (!GameManager.StopCube)
            {
                // 止まっている障害物がこれだったら
                if (!moveFlag)
                {
                    // 左クリックしたら動かす
                    if (Input.GetMouseButtonDown(0))
                    {
                        Instantiate(ClickSE);
                        moveFlag = true;
                        CubeFlag = true;
                        this.GetComponent<MeshRenderer>().material = mat2;
                    }
                }
            }
        }
    }
}