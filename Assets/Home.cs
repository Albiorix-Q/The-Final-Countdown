using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public Button home;
    // Start is called before the first frame update
    void Start()
    {
        home.onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        SceneManager.LoadScene("Shower Scene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
