﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Story : MonoBehaviour
{
    public Text story1;
   // public Text story2;
    movement m1;
    float time;
    fading f1;
    // Start is called before the first frame update
    void Start()
    {
        story1 = GetComponent<Text>();
        //story2 = GetComponent<Text>();
        m1 = GameObject.FindGameObjectWithTag("red_ball").GetComponent<movement>();
        
    }
    // Update is called once per frame
    void Update()
     {
        time += Time.deltaTime;
        

        
        if (m1.stop == true)
            {
            story1.text = "rock1";
            story1.text = "rock";
               
            }

        if (Mathf.Round(time) == 3 && m1.stop == true)
        {
            f1 = GameObject.Find("rock_ball_sprite").GetComponent<fading>();
            f1.fade();
            m1.stop = false;
        }
        if (Mathf.Round(time) == 5 )
        {
            m1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            
            

        }
                                 
    }

    
    
    
        
    }
