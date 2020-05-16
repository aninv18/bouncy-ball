using System.Collections;
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
        

        
        if (Mathf.Round(time) == 2 && m1.stop == true)
            {
           
            story1.text = "This is bounce's friend " +
                          "Bumpy cracks!!! , a boulder";
               
            }

        if (Mathf.Round(time) == 4 && m1.stop == true)
            story1.text = "Press 2 to switch to bumpy " +
                           "cracks and 1 for bounce";



        if (Mathf.Round(time) == 5 && m1.stop == true)
        {
            f1 = GameObject.Find("rock_ball_sprite").GetComponent<fading>();
            f1.fade();
            m1.stop = false;
        }
        if (Mathf.Round(time) == 6 )
        {
            m1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            story1.text = "";       

        }



                                 
    }

    
    
    
        
    }

