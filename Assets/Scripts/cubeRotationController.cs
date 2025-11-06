using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRotationController : MonoBehaviour
{
    public int PlacementNumber;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 worldAngle = myTransform.eulerAngles;

        switch (PlacementNumber)
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
