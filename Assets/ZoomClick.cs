using UnityEngine;
using System.Collections;

public class ZoomClick : MonoBehaviour {

    private float speed = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.localScale.x < 1f)
        {
            Vector3 target = new Vector3(1f, 1f, 1f);
            this.transform.localScale = Vector3.Lerp(this.transform.localScale, target, Time.deltaTime * speed);
        }
	}

    public void clicked()
    {
        this.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
    }
}
