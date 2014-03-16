﻿using UnityEngine;
using System.Collections;
using Assets;

public class InputHandler : MonoBehaviour
{
    private GameObject[] ingredients;
    private Pie pie;    // use covered pie later
    private ProgressBar progressBar;

    void Start()
    {
        ingredients = GameObject.FindGameObjectsWithTag("Ingredient");
        pie = GameObject.FindObjectOfType<Pie>().GetComponent<Pie>();
        progressBar = GameObject.FindObjectOfType<ProgressBar>().GetComponent<ProgressBar>();
    }

    // This function is soooo nested...
    void Update()
    {
        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition3 = Camera.main.ScreenToWorldPoint(touch.position);
                Vector2 touchPosition2 = new Vector2(touchPosition3.x, touchPosition3.y);

                foreach (var ingredient in ingredients)
                {
                    if (Physics2D.OverlapPoint(touchPosition2) == ingredient.collider2D)
                    {
                        ingredient.GetComponent<ZoomClick>().clicked();
                        foreach (var ingredientEnumValue in (IngredientEnum[])System.Enum.GetValues(typeof(IngredientEnum)))
                        {
                            var ingredientName = ingredientEnumValue.ToString();
                            if (ingredient.name == ingredientName)
                            {
                                //Debug.Log(ingredientName);
                                pie.add(ingredientEnumValue);
                                
                            }
                        }
                    }
                }

                if (Physics2D.OverlapPoint(touchPosition2) == pie.collider2D)
                {
                    Debug.Log("Pie is clicked.");
                    pie.GetComponent<Pie>().clicked();
                    progressBar.click();
                }
            }
        }
    }
}
