using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public Shower shower;
    private void Update()
    {
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0.0f;

        if (shower.GetComponent<Shower>().showerSelected)
        {
            transform.position = mousePosition;
        }
    }
}
