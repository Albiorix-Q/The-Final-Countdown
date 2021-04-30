using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodWheel : MonoBehaviour
{
    public GameObject glitchPet;
    public PetStats petStats;
    public bool stopFoodDrop = false;
    public bool foodTraySelected = false;
    float deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            foodTraySelected = true;
        }
        else
            foodTraySelected = false;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FoodWheelTag"))
        {
            deltaTime += 1 * Time.fixedDeltaTime;
            if (deltaTime >= 1)
            {
                glitchPet.GetComponent<PetStats>().food += 1;
                deltaTime--;
            }
            stopFoodDrop = true;
        }
    }
}
