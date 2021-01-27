using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 zoom;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + zoom.x, player.position.y + zoom.y, zoom.z);
    }
}
