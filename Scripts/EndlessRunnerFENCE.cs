using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunnerFENCE : MonoBehaviour
{
    
    private float xpos, startpos, length;

    public GameObject obj;
    public float speed;

    public Timer timer;
    
    // Start is called before the first frame update
    void Start()
    {
        startpos = obj.transform.position.x;
        xpos = startpos;
        length = obj.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xpos = (float)(xpos - speed);
        obj.transform.position = new Vector3 (xpos, transform.position.y, transform.position.z);
        
        if ((xpos < length * -1 ) && !timer.isEnd())
        {
            obj.transform.position = new Vector3(startpos, transform.position.y, transform.position.z);
            
            
            xpos = startpos;

            

        }
    }
}
