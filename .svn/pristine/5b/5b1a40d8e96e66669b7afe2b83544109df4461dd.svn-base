using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startTrigger : MonoBehaviour 
{
    private float startTime;
    public float timer;
    public bool timerIsOn = false;
    public Text TimerText;

    private void OnTriggerEnter(Collider coli)
    {
        if (coli.tag == "Player")
        {
            timerIsOn = true;
        }
    }

    private void Update()
    {
        if (timerIsOn == true)
        {
            timer += Time.deltaTime;

            string minutes = ((int)timer / 60).ToString();
            string seconds = (timer % 60).ToString("f2");

            TimerText.text = minutes + ":" + seconds;
        }
        else
            return;
    }

}
