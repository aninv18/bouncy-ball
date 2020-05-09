using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fading : MonoBehaviour
{
    Color r;

    // Start is called before the first frame update

    // Update is called once per frame
    public void fade()
    {
        r = gameObject.GetComponent<SpriteRenderer>().color;
        if (r.a >= 0)
        {
            Invoke("fade", 0.3f);
            r.a -= 0.2f;
            Debug.Log(r.a);
            gameObject.GetComponent<SpriteRenderer>().color = r;
        }

        if (r.a == 0)
            Destroy(gameObject);
        }

        

    void disappear()
    {
        
       
    }

    }

