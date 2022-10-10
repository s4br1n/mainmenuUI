using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void Start(){
        Debug.Log("game start !");

    }

    public void Exit(){
        Debug.Log("bye !");
        Application.Quit();
    }
}
