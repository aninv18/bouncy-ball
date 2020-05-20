using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject rb;
    public float AddForce = 5f;
    public float AddThrust = 5f;
    public int score = 0;
    public Camera c1;
    public Camera c2;
    public GameObject door;
    public bool isopen = false;
    public float jumpingCoolDown = 0.6f;
    private float jumpTimer = 0f;    
    public bool isMovement = false;        
    public SpriteRenderer lever_G;
    public bool stop = false,stop1 = false;
    private GameObject coll;
    public Animator animator;
    public bool complete = false;
    public GameObject Canvas;






    void Start()
    {
        c1.enabled = true;
        c2.enabled = false;
        isMovement = true;
        lever_G.enabled = false;
        DontDestroyOnLoad(rb);        
        DontDestroyOnLoad(Canvas);
        


    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        { 
            rb.GetComponent<Rigidbody2D>().AddForce(new Vector2(AddForce, 0f), ForceMode2D.Force); 
        }

        else if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.GetComponent<Rigidbody2D>().AddForce(new Vector2(-(AddForce * 1.3f), 0f), ForceMode2D.Force);
        }
        
        if (rb.GetComponent<Rigidbody2D>().velocity.x >= 25f || rb.GetComponent<Rigidbody2D>().velocity.x <= -25f) { rb.GetComponent<Rigidbody2D>().velocity /= 2; }

        jumpTimer -= Time.deltaTime;        
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            if (jumpTimer <= 0f)
            {
                jumpTimer = jumpingCoolDown;
                rb.GetComponent<Rigidbody2D>().AddForce(Vector2.up * AddThrust, ForceMode2D.Force);
            }
            isMovement = true;
            }

       

      




    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("egg"))
        {      
            col.GetComponent<ParticleSystem>().Play();
            score++;
            coll = col.gameObject;
            Invoke("des", 0.1f);   
           // Debug.Log(score);
            return;           
        }
        
        if (col.gameObject.CompareTag("lever"))
          {                   
            
            Destroy(col.gameObject);
            Invoke("DD1", 1);
            
            c2.enabled = true;
            c1.enabled = false;
            float i = 1.1f;

            for ( i = 1.1f; i < 1.8f; i += 0.05f)
            {Invoke("Dmove1", i);}

            int c = 0;
            for ( i = 2.0f; i < 2.4f; i+=0.05f)
                {
                Debug.Log(i);
                c++;
                if (door.transform.localPosition.y <= 37.0f) { Invoke("Dmove", i); }
                }

            lever_G.enabled = true;
            Invoke("DD", 3);
        }

        if (col.tag.Equals("trigger"))
        {
            rb.GetComponent<Rigidbody2D>().velocity *= 0;
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            stop = true;            
            coll = col.gameObject;
            Invoke("des", 0.5f);
        }

        if (col.tag.Equals("trigger2"))
        {
            Invoke("water", 2);
            
        }
        if (col.tag.Equals("trigger3"))
        {
            Invoke("normal", 1);
            
        }
        /*if (col.tag.Equals("trigger4"))
        {
            rb.velocity *= 0;
            rb.bodyType = RigidbodyType2D.Static;
            stop1 = true;
            coll = col.gameObject;
            Invoke("des", 0.5f);
            
        }*/

        if (col.tag.Equals("plant"))
        {
            animator.SetBool("plant", true);
            
            Invoke("setback", 0.2f);
        }
        if (col.tag.Equals("Finish"))
        {
            rb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            complete = true;
            Invoke("scorecard", 2);
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<ParticleSystem>().Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag.Equals("enemy"))
        {
            //Debug.Log(collision.collider.GetType());
            if (collision.collider.GetType() == typeof(CircleCollider2D))
            {

                //Debug.Log("yes");
                collision.collider.GetComponent<ParticleSystem>().Play();
                coll = collision.collider.gameObject;
                Invoke("des", 0.1f);
            }    
        }


        
    }
    
    

    void scorecard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    void Dmove()
    {  
        door.transform.position = door.transform.position + Vector3.up;
        Debug.Log(door.transform.position);
    }
    void Dmove1()
    {
        c2.transform.position = c2.transform.position + new Vector3(2.0f, 0f, 0f);
    }
    void DD()
    {
        //Debug.Log("HELLO");
        c2.enabled = false;
        c1.enabled = true;
    }
    void DD1()
    {
        Debug.Log("HELLO");
    }
    void des()
    {
        Destroy(coll);
    }

    void water()
    {
        Destroy(GameObject.FindGameObjectWithTag("buoyancy"));
        AddForce = 10f;
        AddThrust = 800f;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        rb.GetComponent<Rigidbody2D>().freezeRotation = true;
        GameObject.FindGameObjectWithTag("Particle").GetComponent<ParticleSystem>().Play();
        rb.GetComponent<Rigidbody2D>().gravityScale = 0.3f;        
    }
    void normal()
    {
        
        AddForce = 30f;
        AddThrust = 3500f;
        rb.GetComponent<Rigidbody2D>().freezeRotation = false;
        GameObject.FindGameObjectWithTag("Particle").GetComponent<ParticleSystem>().Stop();
        rb.GetComponent<Rigidbody2D>().gravityScale = 2.3f;


    }

    void setback()
    {
        animator.SetBool("plant", false);
    }

}
