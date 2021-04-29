using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetStats : MonoBehaviour
{
    public int hygene, fun, food;
    public float hygeneTimer, foodTimer, funTimer;
    public Text hygeneText, foodText, funText;

    // Start is called before the first frame update
    void Start()
    {
        hygene = 100;
        food = 100;
        fun = 100;
    }

    // Update is called once per frame
    void Update()
    {
        hygeneText.text = "Hygene: " + hygene + "%";
        foodText.text = "Food: " + food;
        funText.text = "Fun: " + fun + "%";

        hygeneTimer += Time.deltaTime;
        int hygeneSeconds = (int)hygeneTimer % 60;
        if(hygeneSeconds == 1)
        {
            hygene -= 1;
            hygeneTimer = 0.0f;
            hygeneSeconds = 0;
        }

        foodTimer += Time.deltaTime;
        int foodSeconds = (int)foodTimer % 60;
        if(foodSeconds == 1)
        {
            food -= 1;
            foodTimer = 0.0f;
            foodSeconds = 0;
        }

        funTimer += Time.deltaTime;
        int funSeconds = (int)funTimer % 60;
        if(funSeconds == 3)
        {
            fun -= 1;
            funTimer = 0.0f;
            funSeconds = 0;
        }

        //hygenetext color modifier
        if (hygene <= 100 && hygene > 65)
            hygeneText.color = Color.green;
        else if (hygene <= 65 && hygene > 33)
            hygeneText.color = Color.yellow;
        else 
            hygeneText.color = Color.red;

        //foodtext color modifier
        if (food <= 100 && food > 65)
            foodText.color = Color.green;
        else if (food <= 65 && food > 33)
            foodText.color = Color.yellow;
        else
            foodText.color = Color.red;
        
        //funtext color modifier
        if (fun <= 100 && fun > 65)
            funText.color = Color.green;
        else if (fun <= 65 && fun > 33)
            funText.color = Color.yellow;
        else
            funText.color = Color.red;
    }
}
