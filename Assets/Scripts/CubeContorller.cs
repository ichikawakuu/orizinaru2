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
    // ブロックの動き方を管理する
    public float PlacementNumber = 0;

    // x軸の動きの切り替え用
    bool moveX = true;

    // z軸の動きの切り替え用
    bool moveZ = true;

    // x軸の動きを止める
    bool StopMoveX;

    // z軸の動きを止める
    bool StopMoveZ;

    // マウスの止める切り替え
    bool moveFlag = true;

    // 止めたブロックの制限
    public static bool CubeFlag = true;

    public GameObject ClickSE;

    // Start is called before the first frame update
    void Start()
    {
        CubeFlag = true;
        StopMoveX = false;
        StopMoveZ = true;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        if (moveFlag)
        {

            // ブロックの動きを分ける
            switch (PlacementNumber)
            {

                // ルール画面
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

                // ステージ1
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
                // ステージ2下
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

                // ステージ2上
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

                // ステージ3左
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

                // ステージ3真ん中
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

                // ステージ3右
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

                // ステージ4真ん中
                case 4.1f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 0.3)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
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

                // ステージ4左
                case 4.2f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > -1.2)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
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

                // ステージ4右
                case 4.3f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 1.8)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
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

                // ステージ4外周
                case 4.4f:

                    // z軸の移動
                    if (StopMoveZ)
                    {
                        if (pos.z > 3)
                        {
                            StopMoveX = true;
                            StopMoveZ = false;
                            moveX = true;
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

                // ステージ5
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

                // ステージ6内側
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

                // ステージ6外側
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