using UnityEngine;
using System.Collections;
using Assets;

public class GameController : MonoBehaviour {

    public GameObject timer, pie;
    public float roundTime = 3;
    public bool isGameOver; // Would be better to enum for game states if we have time
    public bool isBaking;
    public bool doneBaking;
    private ProgressBar progressBar;

	// Use this for initialization
	void Start () 
    {
        isGameOver = false;
        isBaking = false;
        doneBaking = false;
        timer.GetComponent<Countdown>().startTimer(roundTime);

        progressBar = GameObject.FindObjectOfType<Assets.ProgressBar>().GetComponent<Assets.ProgressBar>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public void BakePie()
    {
        isBaking = true;
        pie.GetComponent<Pie>().startBaking();
    }

    public void ClearPie()
    {
        pie.GetComponent<Pie>().clearIngredient();
    }

    public void KeepTrying()
    {
        isBaking = false;
        doneBaking = false;

        pie.GetComponent<Pie>().Retry();
        progressBar.Reset();
    }

    public void Retry()
    {
        isBaking = false;
        doneBaking = false;
        isGameOver = false;

        pie.GetComponent<Pie>().Retry();
        progressBar.Reset();
        timer.GetComponent<Countdown>().Reset();
    }

    public void DoneBaking()
    {
        isBaking = false;
        doneBaking = true;
        pie.GetComponent<Pie>().doneBaking();
        //float score = timer.GetComponent<Countdown>().GetScore();
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void startTimer()
    {
        
    }
}
