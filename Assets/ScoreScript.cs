using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    public GameObject currency, amount;

	// Use this for initialization
	void Start () {
        currency.renderer.enabled = false;
        currency.renderer.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
