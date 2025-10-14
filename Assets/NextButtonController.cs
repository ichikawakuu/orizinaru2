using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonController : MonoBehaviour
{
    // ステージのカウントを進める変数
    // 使わなくなった
    public static int NextStage = 1;

    // 音を入れる変数
    public AudioClip SE;
    AudioSource audioSource;
    


    // Start is called before the first frame update
    void Start()
    {
        //NextStage = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 初めからにする関数
    public void newStart()
    {
        Debug.Log("呼ばれました");
        NextStage = 0;
    }


    // ボタンが押されたら次のステージ
    public void OnClick()
    {
        //// falseなら最初から
        //if (!StartController.New)
        //{
        //    NextStage = 1;
        //    Debug.Log(NextStage);
        //    SceneManager.LoadScene("GameScene");
        //}
        //
        //// 前回の続きNewがTrueになってるnewStartで値が変わっていない可能性あり
        //else if (StartController.New)
        //{
        //    NextStage++;
        //    Debug.Log(NextStage);
        //    SceneManager.LoadScene("GameScene");
        //}
        audioSource.PlayOneShot(SE);
        StartController.StageCount += 1;
        NextStage += 1;
        Debug.Log(NextStage);
        SceneManager.LoadScene("GameScene");
    }

    
}
