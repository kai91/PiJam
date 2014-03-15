using UnityEngine;
using System.Collections;
using Assets;
using System.Collections.Generic;

public class Pie : MonoBehaviour {

    private int apple, blueberry, cherry;
    private List<KeyValuePair<int, int>> list;
    

	// Use this for initialization
	void Start ()
    {
        initialize(true);
	}

    public void initialize(bool difficulty)
    {
        apple = blueberry = cherry = 0;
        list = new List<KeyValuePair<int, int>>();
        KeyValuePair<int, int> range = Utility.getRange(difficulty);
        list.Add(range);
        range = Utility.getRange(difficulty);
        list.Add(range);
        range = Utility.getRange(difficulty);
        list.Add(range);
    }

	public void add(IngredientEnum ingredient) {
        if (ingredient == IngredientEnum.Apple)
        {
            Debug.Log(apple);
            apple++;
        }
        else if (ingredient == IngredientEnum.Blueberry)
        {
            Debug.Log(blueberry);
            blueberry++;
        }
        else if (ingredient == IngredientEnum.Cherry)
        {
            Debug.Log(cherry);
            cherry++;
        }
	}

    public void doneBaking()
    {
        // Check apple
        if (apple > list[0].Value)
        {
            // too much apple
        }
        else if (apple < list[0].Key)
        {
            // too little apple
        }
        else
        {
            // right amount of apple
        }

        // Check blueberry
        if (blueberry > list[1].Value)
        {
            // too much blueberry
        }
        else if (blueberry < list[1].Key)
        {
            // too little blueberry
        }
        else
        {
            // right amount of blueberry
        }

        // Check cherry
        if (cherry > list[2].Value)
        {
            // too much apple
        }
        else if (cherry < list[2].Key)
        {
            // too little cherry
        }
        else
        {
            // right amount of cherry
        }
    }

    public void clearIngredient()
    {
        apple = blueberry = cherry = 0;
    }
}
