using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("dip", 0.1f);
    }
    void dip()
    {
        obj.GetComponent<BuoyancyEffector2D>().surfaceLevel = obj.GetComponent<BuoyancyEffector2D>().surfaceLevel - 0.005f;
        Debug.Log(obj.GetComponent<BuoyancyEffector2D>().surfaceLevel);
    }
}
