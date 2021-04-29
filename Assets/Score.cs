using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        int height = (int)player.position.y;
        if (height > int.Parse(score.text))
        {
            score.text = "" + height;
        }

    }
}
