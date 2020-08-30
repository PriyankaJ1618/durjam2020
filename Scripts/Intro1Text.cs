using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro1Text : MonoBehaviour
{

    public string[] txts = new string[]{"Paul the Goose has been captured by the Evil Krone Karen",
    "Seeing his demise fast approaching, Paul makes one last daring move to escape", "Wriggling out of Karen's grasp, he makes a mad dash outside"};
    public Text introText;
    private int index;

    public GameObject next;
    // Start is called before the first frame update
    void Awake()
    {
        index = 0;
        introText.text = txts[index];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && index < txts.Length-1){
            index = index + 1;
            introText.text = txts[index];
        }

        if(index==txts.Length-1){
            next.SetActive(true);
        }
        StartCoroutine(Waiting());
    }

    IEnumerator Waiting(){
        yield return new WaitForSecondsRealtime(3);
    }
}
