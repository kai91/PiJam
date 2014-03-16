using UnityEngine;
using System.Collections;

public class BakingPie : MonoBehaviour {

    private float speed = 20;

	// Use this for initialization
	void Start () {
        hidePie();
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.localScale.x < 0.8f)
        {
            Vector3 target = new Vector3(0.8f, 0.8f, 0.8f);
            this.transform.localScale = Vector3.Lerp(this.transform.localScale, target, Time.deltaTime * speed);
        }
	}

    public void clicked()
    {
        this.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
    }

    public void showPie()
    {
        renderer.enabled = true;
    }

    public void hidePie()
    {
        renderer.enabled = false;
    }
}
