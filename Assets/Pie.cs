using UnityEngine;
using System.Collections;
using Assets;
using System.Collections.Generic;

public class Pie : MonoBehaviour {

    public Camera mainCamera;
    private int apple, blueberry, cherry;
    private List<KeyValuePair<int, int>> list;
    public Transform applePrefab, blueberryPrefab, cherryPrefab;
    private bool shrink;
    public GameObject coveredPie;


    private float minXRange = 120;
    private float maxXRange = 280;
    private float minYRange, maxYRange;
    private List<Transform> toppings;

	// Use this for initialization
	void Start ()
    {
        initialize(true);
        minYRange = Screen.height / 5f;
        maxYRange = Screen.height / 2f;
        minXRange = Screen.width / 4f;
        maxXRange = Screen.width / 4f * 3f;
	}

    public void initialize(bool difficulty)
    {
        renderer.enabled = true;
        apple = blueberry = cherry = 0;
        list = new List<KeyValuePair<int, int>>();
        KeyValuePair<int, int> range = Utility.getRange(difficulty);
        list.Add(range);
        range = Utility.getRange(difficulty);
        list.Add(range);
        range = Utility.getRange(difficulty);
        list.Add(range);
        shrink = false;
        toppings = new List<Transform>();

        Debug.Log("apple" + list[0].Key + " " + list[0].Value);
        Debug.Log("blueberry" + list[1].Key + " " + list[1].Value);
        Debug.Log("cherry" + list[2].Key + " " + list[2].Value);

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
        float randomX = Random.Range(minXRange, maxXRange);
        float randomY = Random.Range(minYRange, maxYRange);
        Vector2 pos = mainCamera.ScreenToWorldPoint(new Vector2(randomX, randomY));
        Transform source = null;
        if (type == IngredientEnum.Apple) source = applePrefab;
        else if (type == IngredientEnum.Blueberry) source = blueberryPrefab;
        else if (type == IngredientEnum.Cherry) source = cherryPrefab;

        Transform topping = (Transform)Instantiate(source, pos, Quaternion.identity);
        float angle = Random.Range(0, 360);
        topping.Rotate(new Vector3(0, 0, angle));
        float scale = Random.Range(0.5f, 0.9f);
        topping.localScale = new Vector3 (scale, scale, scale);
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
            Debug.Log("apple correct");
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
            Debug.Log("blueberry correct");
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
            Debug.Log("cherry correct");
        }
    }

    public void clearIngredient()
    {
        apple = blueberry = cherry = 0;
        for (int i = 0; i < toppings.Count; i++)
        {
            Destroy(toppings[i].gameObject);
        }
        toppings.Clear();
    }

    void Update()
    {

        if (transform.localScale.x < 0.8)
        {
            Vector3 target = new Vector3(0.8f, 0.8f, 1);
            transform.localScale = Vector3.Lerp(transform.localScale, target, Time.deltaTime * 5);
        }
    }
    public void startBaking()
    {
        clearIngredient();
        this.renderer.enabled = false;
        coveredPie.GetComponent<BakingPie>().showPie();
    }

    public void Retry()
    {
        coveredPie.GetComponent<BakingPie>().hidePie();
        this.renderer.enabled = true;
    }

    public void clicked()
    {
        coveredPie.GetComponent<BakingPie>().clicked();
    }
}
