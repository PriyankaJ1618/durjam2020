using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenMovements : MonoBehaviour
{

    public GameObject obj;
    private float xpos, length, startpos;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        startpos = 0;
        xpos = startpos;
        length = obj.GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        
        xpos = (float)(xpos - speed);
        obj.transform.position = new Vector3 (xpos, transform.position.y, transform.position.z);
        //sky.transform.position.x = xpos;
        if (length < xpos * -1)
        {
            obj.transform.position = new Vector3(startpos, transform.position.y, transform.position.z);
            xpos = startpos;

        }


  
    }
}
