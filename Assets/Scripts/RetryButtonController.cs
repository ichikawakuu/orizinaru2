using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonController : MonoBehaviour
{

    // ƒ{ƒ^ƒ“SE
    public AudioClip buttonSE;
    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnClick()
    {
        audioSource.PlayOneShot(buttonSE);
        SceneManager.LoadScene("GameScene");
    }
}
