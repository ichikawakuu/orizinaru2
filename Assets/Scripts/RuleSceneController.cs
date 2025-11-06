using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RuleSceneController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // スタートシーンに戻る
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
