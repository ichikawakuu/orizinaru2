using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // アニメーション用変数
    public Animator animator;

    Transform myTransform;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
        pos = myTransform.position;

        pos.x = 20;
        pos.y = 0.05f;
        pos.z = -4;

        myTransform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤー視点のみ
        if (MainCameraController.eye)
        {
            // スペースキーを押したら弾を撃つアニメーション
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("shoot");
            }
        }

        // ステージ
        switch (GameManager.stage)
        {
            // ステージ2
            case 2:

                pos.x = 0;

                myTransform.position = pos;

                break;

            // ステージ3
            case 3:

                pos.x = 40;

                myTransform.position = pos;

                break;

            // ステージ4
            case 4:

                pos.x = 80;

                myTransform.position = pos;

                break;

            // ステージ5
            case 5:

                pos.x = 100;

                myTransform.position = pos;

                break;

            // ステージ6
            case 6:

                pos.x = 60;

                myTransform.position = pos;

                break;

        }
    }
}
