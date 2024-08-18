using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    private float timeLeft = 900f;
    public bool timerOn = false;

    public Text timertext;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
        }
        else
        {
            Debug.Log("Time is over make a death screen to put here!");
            timeLeft = 0;
            timerOn = false;
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1f;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timertext.text = string.Format("{00:00} : {01:00}", minutes, seconds);
    }
}

