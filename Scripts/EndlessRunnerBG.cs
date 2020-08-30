using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunnerBG : MonoBehaviour
{
    public GameObject obj;

    public GameObject sky;


    private float xpos, length, startpos, endpos, beginning;
    public float speed;

    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        startpos = obj.transform.position.x;
        xpos = startpos;

        endpos = sky.GetComponent<SpriteRenderer>().bounds.size.x/-2;
        beginning = sky.GetComponent<SpriteRenderer>().bounds.size.x/2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //obj is the idle goose protestors
        /*
        xpos = (float)(xpos - speed);
        obj.transform.position = new Vector3 (xpos, transform.position.y, transform.position.z);
        
        if (xpos < endpos)
        {
            obj.transform.position = new Vector3(beginning, transform.position.y, transform.position.z);
            xpos = beginning;

        }
        */
        
        if (timer.isEnd()){
            
            xpos = (float)(xpos - speed);
            obj.transform.position = new Vector3 (xpos, transform.position.y, transform.position.z);
            
            
            if (xpos < endpos)
            {
                obj.SetActive(false);

            }

        } else {
            //randomising the beginning placement one object is off the screen
            xpos = (float)(xpos - speed);
            obj.transform.position = new Vector3 (xpos, transform.position.y, transform.position.z);

            if (xpos < endpos)
            {
                float probability = Random.Range(1,11);
                float num = Random.Range(0,3);
                xpos = beginning + (probability*num);
                obj.transform.position = new Vector3(xpos, transform.position.y, transform.position.z);
            } 
            //end of edits
        }

    }
}
