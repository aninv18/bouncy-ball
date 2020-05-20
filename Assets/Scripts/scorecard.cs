using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecard : MonoBehaviour
{
    public Text time;
    public Text score;
    movement m1;
    Timer t1;
    // Start is called before the first frame update
    void Start()
    {
        m1 = GameObject.FindGameObjectWithTag("red_ball").GetComponent<movement>();
        
       
        

    }

    // Update is called once per frame
    void Update()
    {
        if(m1.complete == true)
        {
            float t = Mathf.Round(m1.Canvas.transform.Find("Timer").GetComponent<Timer>().time);
            score.text = m1.score.ToString();

            if (t <= 9)
                time.text = " 00:0" + t.ToString();
            if (t >= 10)
                time.text = " 00:" + t.ToString();
            if (t == 60)
              time.text = " 0" + (t / 60) + ":" + (t - 60).ToString();


        }
        
    }
}
