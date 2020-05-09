using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public Transform startpos;
    Vector3 nextpos;
    // Start is called before the first frame update
    void Start()
    {
        nextpos = startpos.position;
      
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position == pos1.position)
        {
            nextpos = pos2.position;
            
        }

        if (transform.position == pos2.position)
        {
            nextpos = pos1.position;
            
        }
        

        transform.position = Vector3.MoveTowards(transform.position, nextpos, Time.deltaTime * 5.0f);


    }
}
