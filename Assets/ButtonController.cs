using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        Debug.Log("âüÇ≥ÇÍÇΩ!");  // ÉçÉOÇèoóÕ
        Transform myTransform = this.transform;
        Vector3 pos = myTransform.position;

        pos.x = 0f;

        myTransform.position = pos;
    }
}
