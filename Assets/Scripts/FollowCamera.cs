using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    [SerializeField] float cameraHeight = -20f;
    // makes camera position follow the player position

    // LateUpdate used here instead of Update because it shows the result after everything is done rather than one thing after another
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,cameraHeight); 
    }
}
