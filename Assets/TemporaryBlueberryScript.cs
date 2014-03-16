using UnityEngine;
using System.Collections;

public class TemporaryBlueberryScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition3 = Camera.main.ScreenToWorldPoint(touch.position);
                Debug.Log("Touch position: " + touch.position);
                Vector2 touchPosition2 = new Vector2(touchPosition3.x, touchPosition3.y);
                if (collider2D == Physics2D.OverlapPoint(touchPosition2))
                {
                    Debug.Log("hit");
                }
            }
        }
	}

    // Testing purpose
    void OnMouseDown()
    {
        Debug.Log("Mouse Down");
    }
}
