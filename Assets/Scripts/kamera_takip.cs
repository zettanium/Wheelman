using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour
{
    Vector3 aradakifark;

    public float smoothedSpeed = 0.125f;
    public GameObject target;
    public Vector3 CameraOffset;
    public static int CamChange;
    public static bool GameOvers,FinishStatus;
    void Start()
    {

        GameOvers = false;
        FinishStatus = false;
    }

    void Update()
    {
        if(GameOvers==false || FinishStatus==false)
        {
            
        switch (CamChange) // Camera Change 
        {
            case 1:
                CameraOffset = new Vector3(0, 6f, -10f);
                Camera.main.transform.rotation = Quaternion.Euler(20f, 0f, 0f);

                break;
            case 2:
                CameraOffset = new Vector3(8, 8f, -23f);
                Camera.main.transform.rotation = Quaternion.Euler(0f, -15f, 0f);
                break;

            default:
                CameraOffset = new Vector3(0, 6f, -10f);
                Camera.main.transform.rotation = Quaternion.Euler(20f, 0f, 0f);
                break;
        }
            if (target.activeSelf)
            {
                transform.position = target.transform.position + CameraOffset;
            }
        }
    }
}
