using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // ‰¹‚ğ“ü‚ê‚é•Ï”
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
        
    }
    public void OnClick()
    {
        audioSource.PlayOneShot(SE);
        SceneManager.LoadScene("StartScene");
    }
}
