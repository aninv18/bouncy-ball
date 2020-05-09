using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    Text timer;
    void Start()
    {
        time = 0;
        timer = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
      if(time <= 9)
            timer.text = " 00:0"+ Mathf.Round(time).ToString();
        if (time >= 10)
            timer.text = " 00:" + Mathf.Round(time).ToString();
        if (time >= 60)
            timer.text = " 0"+ Mathf.Round(time/60) +":" + Mathf.Round(time-60).ToString();


    }
}
