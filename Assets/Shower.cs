using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour
{

    public GameObject glitchPet;
    public PetStats petStats;
    public bool stopDrop = false;
    Collider petCollider, showerCollider;
    float deltaTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collision Tag"))
        {
            deltaTime += 1 * Time.fixedDeltaTime;
            if (deltaTime >= 1)
            {
                glitchPet.GetComponent<PetStats>().hygene += 1;
                deltaTime--;
            }
            stopDrop = true;
        }
    }

    
}
