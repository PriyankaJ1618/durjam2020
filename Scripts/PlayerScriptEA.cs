using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScriptEA : MonoBehaviour
{

    
    private Rigidbody2D rigidbody2D;
    //private BoxCollider2D boxCollider2D;
    private PolygonCollider2D polygonCollider;

    public Animator animator;

    public GameObject gameOver;


    public GameObject words;

    private float xcol, ycol;

    public int nextSceneInt;



    private void Awake() {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        //boxCollider2D = transform.GetComponent<BoxCollider2D>();
        polygonCollider = transform.GetComponent<PolygonCollider2D>();
        
        // xcol = boxCollider2D.size.x;
        // ycol = boxCollider2D.size.y;
        
        xcol = polygonCollider.transform.localScale.x;
        ycol = polygonCollider.transform.localScale.y;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            float jumpVelocity = 5f;
            rigidbody2D.velocity = Vector2.up * jumpVelocity;
        }

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //boxCollider2D.size = new Vector2(xcol,ycol);
        polygonCollider.transform.localScale = new Vector3(xcol, ycol,polygonCollider.transform.localScale.z); 
        float moveSpeed = 5f;
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        if (Input.GetKey(KeyCode.LeftArrow)){
            rigidbody2D.velocity = new Vector2(-moveSpeed, rigidbody2D.velocity.y);
        } else {
            if (Input.GetKey(KeyCode.RightArrow)) {
                rigidbody2D.velocity = new Vector2(+moveSpeed, rigidbody2D.velocity.y);

            } else if (Input.GetKey(KeyCode.DownArrow)){
                //boxCollider2D.size = new Vector2(xcol, (float)(ycol*0.75));
                
                polygonCollider.transform.localScale = new Vector3(xcol, (float)7.5,polygonCollider.transform.localScale.z);
            } else {
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
                rigidbody2D.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

            }
        }
    }


    private void OnCollisionEnter2D(Collision2D gooseCol){
        if (gooseCol.gameObject.tag == "Enemy")  //If Hit by Protestor must create collider tag hit. :?
        {
            words.SetActive(false);
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }

        if (gooseCol.gameObject.tag == "Finish"){
            SceneManager.LoadScene(nextSceneInt);
        }

    }
    

}
