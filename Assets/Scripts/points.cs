using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class points : MonoBehaviour
{
     int no_of_eggs;
     int count = 0;
    Text score;
    movement m1;
     
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("egg");
        no_of_eggs = npcs.Length;
        Debug.Log(no_of_eggs);
        score = GetComponent<Text>();
        m1 = GameObject.Find("ball").GetComponent<movement>();


    }

    // Update is called once per frame
    void Update()
    {
        score.text = " " + m1.score + " / " + no_of_eggs;
        
        
    }
   
}
