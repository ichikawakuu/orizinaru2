using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    GameObject NEXT;
    NextButtonController nextController;

    // 使わなくなった
    public static bool New = true;

    // ステージ移動の回数
    public static int StageCount = 1;

    // 音を入れる変数
    public AudioClip SE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StageCount = 1;
        New = true;

        NEXT = GameObject.Find("StartButton");
        nextController = NEXT.GetComponent<NextButtonController>();

        NextButtonController.NextStage = 0;

        audioSource = GetComponent<AudioSource>();
    }
    // ボタンを押したらゲーム開始
    public void OnClick()
    {
        audioSource.PlayOneShot(SE);
        New = false;
        SceneManager.LoadScene("GameScene");
    }
}
