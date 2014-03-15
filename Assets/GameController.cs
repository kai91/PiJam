using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject timer;
    private float roundTime = 3;

	// Use this for initialization
	void Start () {
        timer.GetComponent<Countdown>().startTimer(roundTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
