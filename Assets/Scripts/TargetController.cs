using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetController : MonoBehaviour
{
    void Start()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        pos.x = 20;
        pos.y = 0.37f;
        pos.z = 4f;

        myTransform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        switch (GameManager.stage)
        {
            case 2:

                pos.x = 0;

                myTransform.position = pos;

                break;

            case 3:

                pos.x = 40;

                myTransform.position = pos;

                break;

            case 4:

                pos.x = 80;

                myTransform.position = pos;

                break;

            case 5:

                pos.x = 100;

                myTransform.position = pos;

                break;

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
