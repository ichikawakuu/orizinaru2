using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousecheck : MonoBehaviour
{
    // レイが衝突したオブジェクトを保持する
    private RaycastHit hitInfo;
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

            // そのオブジェクトのタグがCubeだったら
            if (hitInfo.collider.gameObject.CompareTag("Cube"))
            {
                hitInfo.collider.gameObject.GetComponent<CubeContorller>().DontMoveCube();
            }
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
