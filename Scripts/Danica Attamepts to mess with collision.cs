using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Danica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    void OnCollisionEnter(Collision GooseCol)
    {
        if (GooseCol.collider.tag == "Hit")  //If Hit by Protestor must create collider tag hit. :?
        {
            //Must Replace with the new Game over Scenes Name
            SceneManager.LoadScene("Game Over");
        }
        if (GooseCol.collider.tag == "Child")
        {
            // Must Replace with the new Game over Scenes Name
            SceneManager.LoadScene("Game Over");
        }
    }


    public class Timer : MonoBehaviour
    {
        public float timeRemaining = 10;

        void Update()
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
            }
        }
    }

    public Text timeText;

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
