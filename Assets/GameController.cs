using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject timer, pie;
    public float roundTime = 3;
    public bool isGameOver; // Would be better to enum for game states if we have time
    public bool isBaking;
    public bool doneBaking;

	// Use this for initialization
	void Start () 
    {
        isGameOver = false;
        isBaking = false;
        doneBaking = false;
        timer.GetComponent<Countdown>().startTimer(roundTime);
    }
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public void ClearPie()
    {
        pie.GetComponent<Pie>().clearIngredient();
    }

    public void startTimer()
    {
        
    }
}
