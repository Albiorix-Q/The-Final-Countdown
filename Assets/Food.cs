using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    //Access pet
    public GameObject glitchPet;
    public PetStats petStats;

    public SpriteRenderer spriteRenderer;
    public Sprite joyStickUpRight;
    public Sprite joyStickLeft;
    public Sprite joyStickRight;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteChanger();
    }

    void SpriteChanger()
    {
        
    }
}
