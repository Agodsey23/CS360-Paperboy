using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float scrollSpeed = 1f;  // Speed at which the camera scrolls

    void Update()
    {
        transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);  // Move the camera upwards
    }
}
