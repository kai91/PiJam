using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

    // 16 characters per line
    // 13 lines
    // total of 208 characters
    private float charCount = 208;
    private bool start;
    private string piValue = "3.141592653589793238462643383279502884197169399375105820974944592307816406286" +
        "208998628034825342117067982148086513282306647093844609550582231725359408128481" +
        "117450284102701938521105559644622948954930381964428810975665933446128475648233" +
        "786783165271201909145648566923460348610454326648213393607260249141273724587006 ";
    private float timeoutTime, currentTime;
    private GameController gameController;
    

	// Use this for initialization
	void Start () 
    {
        start = false;
        currentTime = 0;
        for (int i = 0; i + 16 < piValue.Length; i += 16)
        {
            piValue = piValue.Insert(i + 16, "\n");
        }

        gameController = GameObject.FindObjectOfType<GameController>().GetComponent<GameController>();
    }

    public void startTimer(float time)
    {
        this.timeoutTime = time;
        start = true;
    }

    public void Reset()
    {
        currentTime = 0;
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (start == false) return;

        float delta = Time.deltaTime;
        currentTime += delta;
        int print = (int)(currentTime / timeoutTime * charCount);
        if (print >= charCount)
        {
            //this.guiText.text = "Game Over!";
            gameController.GameOver();

            return;
        }
        string toPrint = piValue.Substring(0, print);
        this.guiText.text = toPrint;
	}
}
