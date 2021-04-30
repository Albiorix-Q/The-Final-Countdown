using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter()
    {
        Debug.Log("Die");
        player.SetActive(false);

    }
}
