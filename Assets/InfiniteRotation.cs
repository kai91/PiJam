using UnityEngine;
using System.Collections;

public class InfiniteRotation : MonoBehaviour {

    private float speed = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Quaternion target = this.transform.rotation;
        //target.z += Time.deltaTime * speed;
        //this.transform.rotation = target;
        transform.Rotate(Vector3.forward * speed * Time.deltaTime, Space.Self);
	}
}
