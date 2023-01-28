using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="white")
        {
            collision.gameObject.SetActive(false);
            
        }
        
    }
    /*
    public void left()
    {
        
    }
    public void right()
    {
       
    }
    public void up()
    {
       
    }
    public void down()
    {
        
    }*/
}
