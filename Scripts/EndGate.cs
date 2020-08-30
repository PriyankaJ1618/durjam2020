using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGate : MonoBehaviour
{

    public Timer timer;

    public GameObject obj;
    
    private float xpos, startpos;

    public float speed;
    public GameObject sky;
    public GameObject gate;
    // Start is called before the first frame update
    void Start()
    {
        startpos = obj.transform.position.x;
        xpos = startpos;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.isEnd() && obj.transform.position.x > ((sky.GetComponent<SpriteRenderer>().bounds.size.x/2) - obj.GetComponent<SpriteRenderer>().bounds.size.x-gate.GetComponent<SpriteRenderer>().bounds.size.x)){
            obj.transform.position = new Vector3(xpos,transform.position.y,transform.position.z);
            xpos = (float)(xpos - speed);
        }
    }
}
