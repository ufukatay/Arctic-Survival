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
    private bool going_up;
    private bool going_down;
    private bool going_right;
    private bool going_left;
    private int counter;
    private Vector3 movement_vec;
    public bool moving;
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
        going_up = false;
        going_down = false;
        going_left = false;
        going_right = false;
        counter = 1;
        movement_vec = new Vector3(0, 0, 0);
        moving = false;
    }
    private void Update()
    {
        if(going_up)
        {
            if(counter <501)
            {
                movement_vec.y = (2f/(500f*500f*Time.deltaTime)) * Time.deltaTime *counter;
            }
            else
            {
                movement_vec.y = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * (1000-counter);
            }
            transform.Translate(movement_vec);
            counter++;
            if(counter == 1001)
            {
                going_up = false;
                moving = false;
            }
        }
        else if(going_down)
        {
            if (counter < 501)
            {
                movement_vec.y = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * counter*(-1);
            }
            else
            {
                movement_vec.y = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * (1000 - counter)*(-1);
            }
            transform.Translate(movement_vec);
            counter++;
            if (counter == 1001)
            {
                going_down = false;
                moving = false;
            }
        }
        else if(going_left)
        {
            if (counter < 501)
            {
                movement_vec.x = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * counter * (-1);
            }
            else
            {
                movement_vec.x = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * (1000 - counter) * (-1);
            }
            transform.Translate(movement_vec);
            counter++;
            if (counter == 1001)
            {
                going_left = false;
                moving = false;
            }
        }
        else if(going_right)
        {
            if (counter < 501)
            {
                movement_vec.x = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * counter;
            }
            else
            {
                movement_vec.x = (2f / (500f * 500f * Time.deltaTime)) * Time.deltaTime * (1000 - counter);
            }
            transform.Translate(movement_vec);
            counter++;
            if (counter == 1001)
            {
                
                going_right = false;
                moving = false;
            }
        }
        else
        {
            counter = 0;
            moving = false;
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {

        if(!moving)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && ud)
            {
                //go_upp = true;
                going_up = true;
                moving = true;
                //transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && d)
            {
                going_down = true;
                moving = true;
                //transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && r)
            {
                going_right = true;
                moving = true;
                //transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && l)
            {
                going_left = true;
                moving = true;
                //transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
            }
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
