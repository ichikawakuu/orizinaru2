using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BulletGenerater : MonoBehaviour
{
    // 音を入れる変数
    public AudioClip SE2;
    AudioSource audioSource;
    // 弾
    public GameObject Bullet;
    // クールタイム変数
    bool cooltime = true;

    private Transform myTransform;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;
        pos = myTransform.position;

        pos.x = 20;
        pos.y = 0.3f;
        pos.z = -3.6f;

        myTransform.position = pos;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // ステージに合わせて位置を変える
        switch (GameManager.stage)
        {
            // ステージ2
            case 2:

                pos.x = 0;

                myTransform.position = pos;

                break;

            // ステージ3
            case 3:

                pos.x = 40;

                myTransform.position = pos;

                break;

            // ステージ4
            case 4:

                pos.x = 80;

                myTransform.position = pos;

                break;

            // ステージ5
            case 5:

                pos.x = 100;

                myTransform.position = pos;

                break;

            // ステージ6
            case 6:

                pos.x = 60;

                myTransform.position = pos;

                break;
        }

        // プレイヤー視点のみ
        if (MainCameraController.eye)
        {
            // スペースキーを押したら弾を撃つ
            if (Input.GetKeyDown(KeyCode.Space) && cooltime)
            {
                // 弾生成
                Instantiate(Bullet, transform.position, Quaternion.identity);
                // クールタイム
                StartCoroutine("BulletTime");
                // 発射音
                audioSource.PlayOneShot(SE2);
            }
        }
    }

    // 弾のクールタイム
    IEnumerator BulletTime()
    {
        cooltime = false;
        yield return new WaitForSeconds(1.0f);
        cooltime = true;
    }
}
