using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Delayed_Event : MonoBehaviour
{
    public float wait_sec = 0f;
    public float wait_sec2 = 0f;
    public class StringEvent: UnityEvent<string> { }
    public UnityEvent delayed_event;
    public UnityEvent delayed_event2;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DelayEvent", wait_sec);
        Invoke("DelayEvent2", wait_sec2);
    }

    void DelayEvent()
    {
        delayed_event.Invoke();
    }
    void DelayEvent2()
    {
        delayed_event2.Invoke();
    }
}
