using UnityEngine;
using UnityEngine.SceneManagement;

public class StartReturnButtonController : MonoBehaviour
{
    // ボタンSE
    public AudioClip buttonSE;
    AudioSource audioSource;
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // ボタンが押されたらスタート画面
    public void OnClick()
    {
        audioSource.PlayOneShot(buttonSE);
        SceneManager.LoadScene("StartScene");
    }
}
