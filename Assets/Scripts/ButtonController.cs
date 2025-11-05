using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    
    public void OnClick()
    {
        Debug.Log("âüÇ≥ÇÍÇΩ!");  // ÉçÉOÇèoóÕ
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        pos.x = 0f;

        myTransform.position = pos;
    }
}
