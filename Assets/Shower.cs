using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour
{

    public GameObject glitchPet;
    PetStats petStats;
    Collider petCollider, showerCollider;
    // Start is called before the first frame update
    void Start()
    {
        if(glitchPet != null)
        {
            petCollider = glitchPet.GetComponent<Collider>();
        }

        if(this != null)
        {
            showerCollider = GetComponent<Collider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (showerCollider.bounds.Intersects(petCollider.bounds))
        {
            petStats.hygene += 1;
        }
    }
}
