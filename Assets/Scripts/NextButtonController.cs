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
        audioSource = GetComponent<AudioSource>();
    }
    // 初めからにする関数
    public void newStart()
    {
        NextStage = 0;
    }


    // ボタンが押されたら次のステージ
    public void OnClick()
    {
        audioSource.PlayOneShot(SE);
        StartController.StageCount += 1;
        NextStage += 1;
        Debug.Log(NextStage);
        SceneManager.LoadScene("GameScene");
    }

    
}
