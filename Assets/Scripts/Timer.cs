using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public GameObject timers;
    void Start()
    {
        time = 0;
        
        DontDestroyOnLoad(timers);


    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time <= 9)
            timers.GetComponent<Text>().text  = " 00:0"+ Mathf.Round(time).ToString();
        if (time >= 10)
            timers.GetComponent<Text>().text = " 00:" + Mathf.Round(time).ToString();
        if (time >= 60)
            timers.GetComponent<Text>().text = " 0"+ Mathf.Round(time/60) +":" + Mathf.Round(time-60).ToString();


    }
}
