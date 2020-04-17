using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetToFollow.position.x, targetToFollow.transform.position.y + 3 , targetToFollow.position.z - 10); // Nao grudar a camera na bola
    }
}