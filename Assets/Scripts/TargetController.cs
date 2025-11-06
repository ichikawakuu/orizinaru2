using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetController : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 pos;
    void Start()
    {
        // 初期位置
        myTransform = this.transform;
        pos = myTransform.position;

        pos.x = 20;
        pos.y = 0.37f;
        pos.z = 4f;

        myTransform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        // ステージに応じて移動
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

    void OnCollisionEnter(Collision collision)
    {
        // 最終ステージならファイナルクリアへ
        if (GameManager.stage == 6)
        {
            SceneManager.LoadScene("FinalClearScene");
        }
        else
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
