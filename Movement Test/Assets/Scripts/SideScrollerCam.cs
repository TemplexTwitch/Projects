using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollerCam : MonoBehaviour
{
    public Transform target;

    [SerializeField] float xMargin = 1f;
    [SerializeField] float yMargin = 1f;
    [SerializeField] float xSmooth = 4f;
    [SerializeField] float ySmooth = 4f;

    public Vector2 minXAndY;
    public Vector2 maxXAndY;

    private void LateUpdate()
    {
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        if(CheckXMargin() == true)
        targetX = Mathf.Lerp(transform.position.x,
                                target.position.x,
                                Time.deltaTime * xSmooth);

        if(CheckYMargin() == true)
        targetY = Mathf.Lerp(transform.position.y,
                                target.position.y,
                                Time.deltaTime * ySmooth);

        //targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        //targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }

    bool CheckXMargin() 
    {
        return Mathf.Abs(transform.position.x - target.position.x) > xMargin;
    }

    bool CheckYMargin()
    {
        return Mathf.Abs(transform.position.y - target.position.y) > yMargin;
    }
}
