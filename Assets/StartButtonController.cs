using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour
{
    //GameObject NEXT;
    //NextButtonController nextController;
    // Start is called before the first frame update

    // 音を入れる変数
    public AudioClip SE;
    AudioSource audioSource;
    

    void Start()
    {
        //NEXT = GameObject.Find("Next");
        //nextController = NEXT.GetComponent<NextButtonController>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ボタンが押されたらスタート画面
    public void OnClick()
    {
        // StartControllerの関数を呼びだす
        //nextController.newStart();
        //NextButtonController.newStart();
        audioSource.PlayOneShot(SE);
        SceneManager.LoadScene("StartScene");
    }
}
