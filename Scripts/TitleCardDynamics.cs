using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCardDynamics : MonoBehaviour
{

    private bool tog;
    public float xmax;
    public float xmin;
    // Start is called before the first frame update
    void Start()
    {
        tog = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x > xmax){
            tog = false;
            

        } else if(transform.localScale.x < xmin) {
            tog = true;
            
        }


        if(tog) {
            transform.localScale += new Vector3(0.0005f,0.0005f,0);
        } else {
            transform.localScale -= new Vector3(0.0005f,0.0005f,0);
        }
        
    }
}
