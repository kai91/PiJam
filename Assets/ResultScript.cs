using UnityEngine;
using System.Collections;

public class ResultScript : MonoBehaviour {

    public GameObject few, many, nice;

	// Use this for initialization
	void Start () {
        hideResult();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void hideResult()
    {
        few.renderer.enabled = false;
        many.renderer.enabled = false;
        nice.renderer.enabled = false;
    }

    public void display(int mode)
    {
        if (mode == 1) few.renderer.enabled = true;
        if (mode == 2) many.renderer.enabled = true;
        if (mode == 3) nice.renderer.enabled = true;
    }
}
