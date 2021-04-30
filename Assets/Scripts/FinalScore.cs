using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    public Text score;
    public Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        finalScore.text = score.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
