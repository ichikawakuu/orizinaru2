using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainCameraController : MonoBehaviour
{
    // 視点切替用
    public static bool eye = true;
    private Transform myTransform;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        eye = true;

        // カメラの初期位置
        myTransform = this.transform;
        pos = myTransform.position;

        pos.x = 0;
        pos.y = 0.37f;
        pos.z = -4;

        myTransform.position = pos;

        // 回転
        Vector3 rot = myTransform.eulerAngles;
        
        rot.x = 0;
        rot.y = 0;
        rot.z = 0;
        
        myTransform.eulerAngles = rot;

        eye = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = myTransform.eulerAngles;

        // 右クリックしたら視点を切り替える
        if (Input.GetMouseButtonUp(1))
        {
            if (eye == true)
            {
                eye = false;
            }
            else
            {
                eye = true;
            }
        }

        // ステージ
        switch (GameManager.stage)
        {
            // ステージ1
            case 1:

                // 上から視点
                if (eye == false)
                {
                    pos.x = 20;
                    pos.y = 4.5f;
                    pos.z = 0;

                    myTransform.position = pos;

                    rot.x = 90;
                    rot.y = -90;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;

                }
                // プレイヤー視点
                else if (eye == true)
                {
                    pos.x = 20;
                    pos.y = 0.37f;
                    pos.z = -4;

                    myTransform.position = pos;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;
                }

                break;

            // ステージ2
            case 2:

                // 上から視点
                if (eye == false)
                {
                    pos.x = 0;
                    pos.y = 4.5f;
                    pos.z = 0;

                    myTransform.position = pos;

                    rot.x = 90;
                    rot.y = -90;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;

                }
                // プレイヤー視点
                else if (eye == true)
                {
                    pos.x = 0;
                    pos.y = 0.37f;
                    pos.z = -4;

                    myTransform.position = pos;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;
                }

                break;

            // ステージ3
            case 3:

                // 上から視点
                if (eye == false)
                {
                    pos.x = 40;
                    pos.y = 4.5f;
                    pos.z = 0;

                    myTransform.position = pos;

                    rot.x = 90;
                    rot.y = -90;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;

                }
                // プレイヤー視点
                else if (eye == true)
                {
                    pos.x = 40;
                    pos.y = 0.37f;
                    pos.z = -4;

                    myTransform.position = pos;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;
                }

                break;

            // ステージ4
            case 4:

                // 上から視点
                if (eye == false)
                {
                    pos.x = 80;
                    pos.y = 4.5f;
                    pos.z = 0;

                    myTransform.position = pos;

                    rot.x = 90;
                    rot.y = -90;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;

                }
                // プレイヤー視点
                else if (eye == true)
                {
                    pos.x = 80;
                    pos.y = 0.37f;
                    pos.z = -4;

                    myTransform.position = pos;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;
                }

                break;

            // ステージ5
            case 5:

                // 上から視点
                if (eye == false)
                {
                    pos.x = 100;
                    pos.y = 4.5f;
                    pos.z = 0;

                    myTransform.position = pos;

                    rot.x = 90;
                    rot.y = -90;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;

                }
                // プレイヤー視点
                else if (eye == true)
                {
                    pos.x = 100;
                    pos.y = 0.37f;
                    pos.z = -4;

                    myTransform.position = pos;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;
                }

                break;

            // ステージ6
            case 6:

                // 上から視点
                if (eye == false)
                {
                    pos.x = 60;
                    pos.y = 4.5f;
                    pos.z = 0;

                    myTransform.position = pos;

                    rot.x = 90;
                    rot.y = -90;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;

                }
                // プレイヤー視点
                else if (eye == true)
                {
                    pos.x = 60;
                    pos.y = 0.37f;
                    pos.z = -4;

                    myTransform.position = pos;

                    rot.x = 0;
                    rot.y = 0;
                    rot.z = 0;

                    myTransform.eulerAngles = rot;
                }

                break;

        }
    }
}
