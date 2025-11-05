using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour
{
    // 音を入れる変数
    public AudioClip SE;
    AudioSource audioSource;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // ボタンが押されたらスタート画面
    public void OnClick()
    {
        audioSource.PlayOneShot(SE);
        SceneManager.LoadScene("StartScene");
    }
}
