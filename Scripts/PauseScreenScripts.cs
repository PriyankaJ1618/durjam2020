using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenScripts : MonoBehaviour
{

    public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Pause()
    {

        pause.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void Resume(){
        pause.SetActive(false);
        Time.timeScale = 1;
    }
    
}
