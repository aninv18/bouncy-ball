using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocks : MonoBehaviour
{
    rockball r1;
    trigger t1;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t1 = GameObject.Find("trigger1").GetComponent<trigger>();
        if (t1.b1)
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            Debug.Log(gameObject.GetComponent<Rigidbody2D>().bodyType);
        }

        
    }

    
}
