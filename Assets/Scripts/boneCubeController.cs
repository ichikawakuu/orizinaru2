using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boneCubeController : MonoBehaviour
{
    public int FinalNum;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        Vector3 worldAngle = myTransform.eulerAngles;

        switch (FinalNum)
        {
            case 1:

                worldAngle.y += speed;
                worldAngle.z += speed;

                myTransform.eulerAngles = worldAngle;

                break;

            case 2:

                worldAngle.y -= speed;
                worldAngle.z -= speed;

                myTransform.eulerAngles = worldAngle;

                break;

        }
    }
}
