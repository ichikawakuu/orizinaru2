using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //bool shot;

    //public GameObject Bullet2;
    // Start is called before the first frame update
    void Start()
    {
        //shot = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.2f);
        //// スペースキーを押したら弾を撃つ
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(Bullet2, transform.position, Quaternion.identity);
        //    //shot = true;
        //}
        
        //if (shot == true)
        //{
        //    Transform myTransform = this.transform;
        //
        //    Vector3 pos = myTransform.position;
        //
        //    pos.z += 0.01f;
        //
        //    myTransform.position = pos;
        //}
    }
}
