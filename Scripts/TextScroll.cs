using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TextScroll : MonoBehaviour
{

    public GameObject text;

    private float ypos,startpos;

    public float speed;

    public GameObject img;

    public CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        startpos = text.transform.position.y;
        ypos = startpos;
    }

    // Update is called once per frame
    void Update()
    {
        
        ypos = ypos + speed;
        text.transform.position = new Vector3(transform.position.x, ypos, transform.position.z);

        if(ypos > img.transform.position.y){
            StartCoroutine(GoFade());
        }

        if(text.tag == "Finish" && ypos >= img.transform.position.y){
            StartCoroutine(Waiting());
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator Waiting(){
        yield return new WaitForSecondsRealtime(3);
    }
    IEnumerator GoFade(){
        while (canvasGroup.alpha<=1){
            canvasGroup.alpha += Time.deltaTime/200;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }

}
