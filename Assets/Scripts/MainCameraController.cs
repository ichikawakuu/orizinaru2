using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainCameraController : MonoBehaviour
{
    public static bool eye = true;
    // Start is called before the first frame update
    void Start()
    {
        eye = true;

        // カメラの初期位置
        // transformを取得
        Transform myTransform = this.transform;

        // 位置
        Vector3 pos = myTransform.position;

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
        // transformを取得
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;

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
