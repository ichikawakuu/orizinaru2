using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousecheck : MonoBehaviour
{
    // レイが衝突したオブジェクトを保持する変数
    private RaycastHit hitInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // マウスのスクリーン座標を取得
        Vector3 mousePosition = Input.mousePosition;

        // スクリーン座標をワールド空間に変換
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        // レイキャストを行い、何かに当たった場合
        if (Physics.Raycast(ray, out hitInfo))
        {
            // 当たったオブジェクトの名前を表示
            Debug.Log("当たったオブジェクト: " + hitInfo.collider.gameObject.name);
            // 問答無用でどっちも持ってるという判定のせいでエラー
            // 解決法１　マウスが当たって呼ばれる関数を他で１つ作り、継承して呼び出しオーバーライドする　正攻法
            // 解決法２　タグを付けてそれぞれ分岐させる　　邪道
            //GameObject hoge;
            //GameObject cube = GameObject.FindWithTag("Cube");
            //GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
            //GameObject Holecube = GameObject.FindWithTag("HoleCube");
            //if (/*hogeのタグがCubeと同じだったら*/)

            // そのオブジェクトのタグがCubeだったら
            if (hitInfo.collider.gameObject.CompareTag("Cube"))
            {
                hitInfo.collider.gameObject.GetComponent<CubeContorller>().DontMoveCube();
                //Debug.Log("キューブです");
            }
            //if (/*hogeのタグがHoleCubeと同じだったら*/)
            // そのオブジェクトのタグがHoleCubeだったら
            else if (hitInfo.collider.gameObject.CompareTag("HoleCube"))
            {
                hitInfo.collider.gameObject.GetComponent<HoleCubeController>().DontMoveHoleCube();
            }
            // そのオブジェクトのタグがHoleだったら
            else if (hitInfo.collider.gameObject.CompareTag("Hole"))
            {
                hitInfo.collider.gameObject.GetComponent<HoleController>().DontMoveHole();
            }
            // そのオブジェクトのタグがWallだったら
            else if (hitInfo.collider.gameObject.CompareTag("Wall"))
            {
                hitInfo.collider.gameObject.GetComponent<WallController>().DontMoveWall();
            }
            // そのオブジェクトのタグがStartCubeだったら
            if (hitInfo.collider.gameObject.CompareTag("StartCube"))
            {
                hitInfo.collider.gameObject.GetComponent<StartCubeContoroller>().DontMoveCube();
            }

        }
        else
        {
            // 何も当たっていない場合
            Debug.Log("何も当たっていません");
        }
    }
}
