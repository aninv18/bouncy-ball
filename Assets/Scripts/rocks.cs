using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocks : MonoBehaviour
{
    rockball r1;
    trigger t1;
    fading f1;


    // Start is called before the first frame update
    void Start()
    {
        f1 = GameObject.Find("rock_ball_sprite").GetComponent<fading>();
    }

    // Update is called once per frame
    void Update()
    {
        t1 = GameObject.Find("trigger1").GetComponent<trigger>();
        f1 = GameObject.Find("rock_ball_sprite").GetComponent<fading>();
        if (t1.b1)
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
           // Debug.Log(gameObject.GetComponent<Rigidbody2D>().bodyType);
            f1.fade();

        }

        
    }

    
}
