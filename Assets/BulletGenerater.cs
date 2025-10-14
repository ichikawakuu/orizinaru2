using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BulletGenerater : MonoBehaviour
{
    // 音を入れる変数
    public AudioClip SE2;
    AudioSource audioSource;

    public GameObject Bullet2;

    // クールタイム変数
    bool cooltime = true;
    // Start is called before the first frame update
    void Start()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        pos.x = 20;
        pos.y = 0.3f;
        pos.z = -3.6f;

        myTransform.position = pos;

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        switch (GameManager.stage)
        {
            case 1:

                break;

            case 2:

                pos.x = 0;

                myTransform.position = pos;

                break;

            case 3:

                pos.x = 40;

                myTransform.position = pos;

                break;

            case 4:

                pos.x = 80;

                myTransform.position = pos;

                break;

            case 5:

                pos.x = 100;

                myTransform.position = pos;

                break;

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
                Instantiate(Bullet2, transform.position, Quaternion.identity);
                StartCoroutine("BulletTime");
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
