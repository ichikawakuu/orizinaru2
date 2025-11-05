using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCubeContoroller : MonoBehaviour
{
    // マテリアル変更用
    [SerializeField] Material mat = default;
    [SerializeField] Material mat2 = default;

    // x軸の動きの切り替え用変数
    bool moveY = true;

    // x軸の動きの切り替え用変数
    bool moveX = true;

    // y軸の動きを止める変数
    bool StopMoveY = true;

    // x軸の動きを止める変数
    bool StopMoveX = true;

    // マウスの止める切り替え変数
    bool moveFlag = true;

    public GameObject ClickSE;

    // Start is called before the first frame update
    void Start()
    {
        // y軸の動きを止める
        StopMoveY = false;

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;
        
        if (moveFlag)
        {
            // スタート画面では視点を切り替えないので常時止めれる用
            MainCameraController.eye = false;

            // スタート画面の場合
            // 縦軸移動 x→y
            // 横軸移動 z→x

            // x軸の移動
            if (StopMoveX)
            {
                if (pos.x > 3.5)
                {
                    StopMoveY = true;
                    StopMoveX = false;
                    moveY = false;
                }
                if (pos.x < -3.5)
                {
                    StopMoveY = true;
                    StopMoveX = false;
                    moveY = true;
                }
            }
            // y軸の移動
            else if (StopMoveY)
            {
                if (pos.y > 2)
                {
                    StopMoveY = false;
                    StopMoveX = true;
                    moveX = true;
                }
                else if (pos.y < 0.3)
                {
                    StopMoveY = false;
                    StopMoveX = true;
                    moveX = false;
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
            // y軸を動かすなら
            if (StopMoveY)
            {
                if (moveY)
                {
                    pos.y += 0.1f;
            
                    myTransform.position = pos;
                }
                else if (!moveY)
                {
                    pos.y -= 0.1f;
            
                    myTransform.position = pos;
                }
            }
        }
    }

    // マウスが当たっていたら
    public void DontMoveCube()
    {
        // この障害物が止まっていなかったら
        if (moveFlag)
        {
            // 左クリックしたら止める
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(ClickSE);
                moveFlag = false;
                this.GetComponent<MeshRenderer>().material = mat;
            }
        }
        // 止まっている障害物がこれだったら
        else if (!moveFlag)
        {
            // 左クリックしたら動かす
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(ClickSE);
                moveFlag = true;
                this.GetComponent<MeshRenderer>().material = mat2;
            }
        }
    }
}


