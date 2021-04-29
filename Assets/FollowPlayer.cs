using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;

    public float moveRoom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > transform.position.y + moveRoom)
        {
            transform.position = new Vector3(transform.position.x, player.position.y - moveRoom, transform.position.z);
        }
    }
}
