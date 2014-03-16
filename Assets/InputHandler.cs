using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    GameObject[] ingredients;
    // Use this for initialization
    void Start()
    {
        ingredients = GameObject.FindGameObjectsWithTag("Ingredient");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition3 = Camera.main.ScreenToWorldPoint(touch.position);
                //Debug.Log("Touch position: " + touch.position);
                Vector2 touchPosition2 = new Vector2(touchPosition3.x, touchPosition3.y);

                foreach (var ingredient in ingredients)
                {
                    if (Physics2D.OverlapPoint(touchPosition2) == ingredient.collider2D)
                    {
                        Debug.Log(ingredient.name);
                    }
                }
            }
        }
    }
}
