using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is somewhat redundant, the camera can simply be attached as a child object of the player
public class FollowPlayer : MonoBehaviour
{
    // variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 10, -7);

    // LateUpdate is used to prevent jittery camera
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
