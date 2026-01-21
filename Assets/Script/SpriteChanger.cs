using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col; // adds a color picker to the inspector
    //public Sprite[] barrels; // array of sprites
    public List<Sprite> barrels; // make sure to delete 'using Nunit Framework' if you use a list
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // spriteRenderer.color = Color.red;
        // PickARandomColor();
        // spriteRenderer.color = col;
        PickARandomSprite();


    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            //PickARandomColor();
            Debug.Log("Try to change the sprite");
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
     
        }


        // spriteRenderer.sprite.bounds.Contains() IS NOT CORRECT DO NOT USE
        // USE THIS: spriteRenderer.bounds.Contains() is at the correct position to follow the sprite across the screen


        //get the mouse position
        //is it over the sprite?
        //Y: use the color variable
        //N: set the color to white

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {

            barrels.RemoveAt(0); // gives errors if you remove the whole list when you haven't set the extra conditional

        }
    }

    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number between 0 and 2
        //use that to set the sprite

        randomNumber = Random.Range(0, barrels.Count); //max is exclusive

        spriteRenderer.sprite = barrels[randomNumber];

        /* don't need this with the array implementation above
                if (randomNumber == 0)
                {
                    spriteRenderer.sprite = barrel0;
                }
                else if (randomNumber == 1)
                {
                    spriteRenderer.sprite = barrel1;
                }
                else if (randomNumber == 2)
                {
                    spriteRenderer.sprite = barrel2;
                }

        */
    }
}
