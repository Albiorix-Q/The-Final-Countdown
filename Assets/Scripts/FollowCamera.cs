using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < camera.transform.position.y - camera.transform.lossyScale.y)
        {
            transform.position = new Vector3(transform.position.x, camera.transform.position.y - camera.transform.lossyScale.y, transform.position.z);
        }
    }
}
