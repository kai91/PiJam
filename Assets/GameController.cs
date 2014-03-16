using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject timer, pie;
    public float roundTime = 3;
    public bool isGameOver;

	// Use this for initialization
	void Start () 
    {
        isGameOver = false;
        timer.GetComponent<Countdown>().startTimer(roundTime);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
