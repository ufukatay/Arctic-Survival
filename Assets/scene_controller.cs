using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_controller : MonoBehaviour
{
    SceneManager sm;
    public bool restart;
    // Start is called before the first frame update
    void Start()
    {
        restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            restart = true;
        }
        
        if(restart)
        {
            SceneManager.LoadScene("Lvl1");
        }
    }
}
