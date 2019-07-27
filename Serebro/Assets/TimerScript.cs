using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Time;

public class TimerScript : MonoBehaviour
{

    int secondsLeft, minutes, seconds;
    float nextTime = 0;
	public Text timerText;

    void Start(){
        timerText = GetComponent<Text>();
	    timerText.text = "120";
        secondsLeft = 120;
    }

    void Update(){
        if (Time.time >= nextTime){
            secondsLeft-=1;
            nextTime+=1;
            minutes = secondsLeft / 60;
            seconds = secondsLeft % 60;
            //TODO añadir ceros

            timerText.text = minutes.ToString()+":"+seconds.ToString();
        }
    }

}
