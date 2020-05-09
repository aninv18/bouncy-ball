using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockball : MonoBehaviour
{

    public GameObject balls;
    public GameObject rock;
    public GameObject red;
    public bool b1 = false;

    // Start is called before the first frame update
    void Start()

    {
       
        rock.SetActive(false);
        rock.transform.position = red.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKey(KeyCode.Alpha1))
        {
            red.transform.position = rock.transform.position;
            red.SetActive(true);
            rock.SetActive(false);
            

        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            rock.transform.position = red.transform.position;
            red.SetActive(false);
            rock.SetActive(true);
            b1 = true;
            
        }



    }

}
