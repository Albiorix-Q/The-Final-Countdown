using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrayMousePosition : MonoBehaviour
{
    public FoodWheel foodTray;
   
    // Update is called once per frame
    void Update()
    {
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0.0f;

        if (foodTray.GetComponent<FoodWheel>().foodTraySelected)
            transform.position = mousePosition;
    }
}
