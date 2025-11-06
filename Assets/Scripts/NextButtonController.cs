using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonController : MonoBehaviour
{
    // ボタンSE
    public AudioClip buttonSE;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // ボタンが押されたら次のステージ
    public void OnClick()
    {
        audioSource.PlayOneShot(buttonSE);
        StartController.StageCount += 1;
        SceneManager.LoadScene("GameScene");
    }

    
}
