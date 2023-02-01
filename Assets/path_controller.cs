using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class path_controller : MonoBehaviour
{
    
    
    public class StringEvent : UnityEvent<string> { }
    public UnityEvent evnt;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("red") && collision.IsTouching(gameObject.GetComponent<CircleCollider2D>()))
        {
            Invoke("evntf", 0.8f);
            
            
        }
    }

    void evntf()
    {
        evnt.Invoke();
    }
}
