using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MenuScript : MonoBehaviour
{
	private int score = 0;
	public float timeStart;
	public Text textBox;
	public Text scoreText;

	bool timerActive = true;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text="00:00:000";
    }

    // Update is called once per frame
    void Update()
    {
    	if (timerActive){
    		timeStart += Time.deltaTime;
    		int minutes = (int)timeStart / 60;
    		int seconds = (int)timeStart % 60;
        	textBox.text = String.Format("Time: {0:D2}:{1:D2}", minutes, seconds);
        	score = seconds + minutes * 60;
        	scoreText.text = String.Format("Score: {0}", score.ToString("D"));
    	}

    }

    public void toggleTime(){
    	timerActive = !timerActive;
    }
}
