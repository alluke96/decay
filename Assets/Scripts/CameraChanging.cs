using System;
using UnityEngine;

public class CameraChanging : MonoBehaviour
{
    //----------------------------------------------------------------------------------------------------------------
    // Serialized fields
    //----------------------------------------------------------------------------------------------------------------
    [SerializeField] private Camera _followingCamera;
    [SerializeField] private Camera _perspectiveCamera;

    //----------------------------------------------------------------------------------------------------------------
    // Unity events
    //----------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        _followingCamera.enabled = true;
        _perspectiveCamera.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _followingCamera.enabled = !_followingCamera.enabled;
            _perspectiveCamera.enabled = !_perspectiveCamera.enabled;
        }
    }
}
