using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public Button tryAgain;
    // Start is called before the first frame update
    void Start()
    {
        tryAgain.onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
