using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject timer, pie;
    public float roundTime = 3;
    public bool isGameOver;
    public bool isBaking;

	// Use this for initialization
	void Start () 
    {
        isGameOver = false;
        isBaking = false;
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
