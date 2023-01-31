using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    [SerializeField] BoxCollider2D up;
    [SerializeField] BoxCollider2D down;
    [SerializeField] BoxCollider2D left;
    [SerializeField] BoxCollider2D right;
    [SerializeField] CircleCollider2D cc2d;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] bool l, r, d, ud;
    public int acc;
    public int dacc;
    public int consta;
    
    // Start is called before the first frame update
    void Start()
    {
        l = true;
        r = true;
        d = false;
        ud = true;
        acc = 21;
        dacc = 81;
        consta = 100;
        
    }
    
    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && ud)
        {
            //go_upp = true;
            //go_up();
            transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && d)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && r)
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && l)
        {
            transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
        }


    }
    
   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "white" && cc2d.IsTouching(collision))
        {
            collision.gameObject.SetActive(false);

        }

        if(collision.tag == "map_limit")
        {
            if (left.IsTouching(collision))
            {
                l = false;
            }
           

            if (right.IsTouching(collision))
            {
                r = false;
            }
            

            if (down.IsTouching(collision))
            {
                d = false;
            }
           

            if (up.IsTouching(collision))
            {
                ud = false;
            }
           
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        

        if (collision.tag == "map_limit")
        {
            if (!left.IsTouching(collision))
            {
                l = true;
            }


            if (!right.IsTouching(collision))
            {
                r = true;
            }


            if (!down.IsTouching(collision))
            {
                d = true;
            }


            if (!up.IsTouching(collision))
            {
                ud = true;
            }

        }

    }
    
   
}
