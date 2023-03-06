using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;
    private Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - objectToFollow.transform.position;
    }

    private void Update()
    {
        Vector3 newPosition = objectToFollow.transform.position + cameraOffset;
        newPosition.x = transform.position.x;
        transform.position = newPosition;
    }
}
