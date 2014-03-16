﻿using UnityEngine;
using System.Collections;
using Assets;
using System.Collections.Generic;

public class Pie : MonoBehaviour {

    public Camera mainCamera;
    private int apple, blueberry, cherry;
    private List<KeyValuePair<int, int>> list;
    public Transform applePrefab, blueberryPrefab, cherryPrefab;
    private bool shrink;


    private float minRange = 150;
    private float maxRange = 250;
    private List<Transform> toppings;

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
        shrink = false;
        Vector2 s = mainCamera.ScreenToWorldPoint(new Vector2(250, 250));
        toppings = new List<Transform>();
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
        addTopping(ingredient);
	}

    private void addTopping(IngredientEnum type)
    {
        float randomX = Random.Range(minRange, maxRange);
        float randomY = Random.Range(minRange, maxRange);
        Transform source = null;
        if (type == IngredientEnum.Apple) source = applePrefab;
        else if (type == IngredientEnum.Blueberry) source = blueberryPrefab;
        else if (type == IngredientEnum.Cherry) source = cherryPrefab;

        Transform topping = (Transform)Instantiate(source, new Vector2(randomX, randomY), Quaternion.identity);
        topping.rotation = Random.rotation;
        toppings.Add(topping);
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
        for (int i = 0; i < toppings.Count; i++)
        {
            Destroy(toppings[i].gameObject);
        }
    }

    void Update()
    {

        if (transform.localScale.x < 0.8)
        {
            Vector3 target = new Vector3(0.8f, 0.8f, 1);
            transform.localScale = Vector3.Lerp(transform.localScale, target, Time.deltaTime * 5);
        }
    }
}
