using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{

    public int scene;



    public void OnClick(){
        if(Time.timeScale == 0){
            Time.timeScale = 1;
        }
        SceneManager.LoadScene(scene);
        
    }
}
