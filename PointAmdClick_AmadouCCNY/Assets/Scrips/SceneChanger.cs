using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //use scene management librabry 

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    // global variable 
    public int sceneNumber;
    //0= start 
    //1= main scene 
    //2= End scene 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (sceneNumber == 2)
        {
            StartSceneControls();
        }
        else if (sceneNumber == 1)
        {
            MainSceneControls();
        }
        else if (sceneNumber== 0)
        {
            EndSceneControls();
        }

       
           
    }
    public void StartSceneControls()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
    public void MainSceneControls()
    {
      if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("EndScene");
        }
    }
    public void EndSceneControls()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
} 
