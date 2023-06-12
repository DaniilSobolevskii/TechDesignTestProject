using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
   public void ChangeScene()
   { 
       
       if (SceneManager.GetActiveScene().name == "scene_1") 
       {
          SceneManager.LoadScene(sceneName: "scene_2"); 
       } 
       if(SceneManager.GetActiveScene().name == "scene_2") 
       {
          SceneManager.LoadScene(sceneName: "scene_1"); 
       }
     
   }
}