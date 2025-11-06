using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    // ステージ移動の回数
    public static int StageCount = 1;

    // ボタンSE
    public AudioClip buttonSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        StageCount = 1;

        audioSource = GetComponent<AudioSource>();
    }
    // ボタンを押したらゲーム開始
    public void OnClick()
    {
        audioSource.PlayOneShot(buttonSE);
        SceneManager.LoadScene("GameScene");
    }
}
