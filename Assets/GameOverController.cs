using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // 音を入れる変数
    public AudioClip SE;
    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //// 左クリックしたらスタート画面(仮)
        //if (Input.GetMouseButtonDown(0))
        //{
        //    SceneManager.LoadScene("StartScene");
        //}
    }
    public void OnClick()
    {
        audioSource.PlayOneShot(SE);
        SceneManager.LoadScene("StartScene");
    }
}
