using UnityEngine;
using System.Collections;

public class CameraZoomOnHide : MonoBehaviour
{
    [Header("Objects")]
    public GameObject square1;
    public GameObject square2;
    public GameObject square3;

    // when any of those game objects are selected zoom out the camera
    void Update()
    {
        if (square1.activeSelf || square2.activeSelf || square3.activeSelf)
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 10f, Time.deltaTime * 2f);
        }
        else
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5f, Time.deltaTime * 2f);
        }
    }

}