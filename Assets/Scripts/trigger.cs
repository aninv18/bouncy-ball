using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool b1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("rock_ball"))
        {
            //Debug.Log("COLLIDED");
            b1 = true;

        }
    }
}
